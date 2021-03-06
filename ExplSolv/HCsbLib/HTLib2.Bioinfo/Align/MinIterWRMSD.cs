﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HTLib2;
using HTLib2.Bioinfo;

namespace HTLib2.Bioinfo
{
    public partial class Align
    {
        public class MinIterWRMSD : IMinAlign
        {
            public static Trans3 GetTrans(IList<Vector> C1, IList<Vector> C2, HPack<int> optIter=null, HPack<List<double>> optListWeightSum=null)
            {
                HDebug.Assert(C1.Count == C2.Count);
                int size = C1.Count;
                if(optIter != null) optIter.value = 0;

                Trans3 trans0 = new Trans3(new double[3], 1, Quaternion.UnitRotation);
                Trans3 trans1 = Geometry.AlignPointPoint.MinRMSD.GetTrans(C2, C1);
                if(optListWeightSum != null) optListWeightSum.value = new List<double>();
                while((trans0.TransformMatrix - trans1.TransformMatrix).ToArray().HAbs().HMax() > 0.00000001)
                {
                    if(optIter != null) optIter.value++;
                    Vector[] C2trans = trans1.GetTransformed(C2).ToArray();

                    double[] weight = new double[size];
                    double[] dist2s = new double[size];
                    for(int i=0; i<size; i++)
                    {
                        double dist2 = (C1[i] - C2trans[i]).Dist2;
                        dist2 = HMath.Between(0.001, dist2, double.PositiveInfinity);
                        weight[i] = 1 / dist2;
                        dist2s[i] = dist2;
                    }
                    if(optListWeightSum != null) optListWeightSum.value.Add(weight.Sum());

                    trans0 = trans1;
                    trans1 = Geometry.AlignPointPoint.MinRMSD.GetTrans(C2, C1, weight);
                }

                return trans1;
            }
            public static void Align(List<Pdb.Atom> atoms1, ref List<Pdb.Atom> atoms2)
            {
                PdbStatic.SelectCommonAtoms(ref atoms1, ref atoms2);
                List<Vector> coords1 = atoms1.ListCoord();
                List<Vector> coords2 = atoms2.ListCoord();

                Trans3 trans = GetTrans(coords1, coords2);
                List<Vector> coords2a = new List<Vector>(trans.GetTransformed(coords2));
                atoms2 = atoms2.CloneByUpdateCoord(coords2a);
            }
            public static void Align(List<Vector> coords1, ref List<Vector> coords2)
            {
                Trans3 trans = GetTrans(coords1, coords2);
                coords2 = new List<Vector>(trans.GetTransformed(coords2));
            }
            public static void Align(string pdbpath1, string pdbpath2, string alignedpath2)
            {
                Pdb pdb1 = Pdb.FromFile(pdbpath1); List<Pdb.Atom> atoms1 = pdb1.atoms.SelectByChainID().SelectByAltLoc();
                Pdb pdb2 = Pdb.FromFile(pdbpath2); List<Pdb.Atom> atoms2 = pdb2.atoms.SelectByChainID().SelectByAltLoc();
                Align(atoms1, ref atoms2);

                Pdb.ToFile(alignedpath2, atoms2);
            }
        }
    }
}
