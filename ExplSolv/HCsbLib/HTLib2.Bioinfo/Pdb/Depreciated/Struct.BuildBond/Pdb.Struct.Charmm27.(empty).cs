﻿/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HTLib2.Bioinfo
{
public partial class Pdb
{
public partial class Struct
{
public partial class Charmm27
{
//  *>>>>>> Combined CHARMM All-Hydrogen Topology File for <<<<<<<<<
//  *>>>>>>>>> CHARMM22 Proteins and CHARMM27 Lipids <<<<<<<<<<
//  *from
//  *>>>>>>>>CHARMM22 All-Hydrogen Topology File for Proteins <<<<<<
//  *>>>>>>>>>>>>>>>>>>>>> August 1999 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<
//  *>>>>>>> Direct comments to Alexander D. MacKerell Jr. <<<<<<<<<
//  *>>>>>> 410-706-7442 or email: alex,mmiris.ab.umd.edu  <<<<<<<<<
//  *and
//  *  \\\\\\\ CHARMM27 All-Hydrogen Lipid Topology File ///////
//  *  \\\\\\\\\\\\\\\\\\ Developmental /////////////////////////
//  *              Alexander D. MacKerell Jr.
//  *                     August 1999
//  * All comments to ADM jr.  email: alex,mmiris.ab.umd.edu
//  *              telephone: 410-706-7442
//  *
//  27  1
//  
//  !
//  ! references
//  !
//  !PROTEINS
//  !
//  !MacKerell, Jr., A. D.; Bashford, D.; Bellott, M.; Dunbrack Jr., R.L.;
//  !Evanseck, J.D.; Field, M.J.; Fischer, S.; Gao, J.; Guo, H.; Ha, S.;
//  !Joseph-McCarthy, D.; Kuchnir, L.; Kuczera, K.; Lau, F.T.K.; Mattos,
//  !C.; Michnick, S.; Ngo, T.; Nguyen, D.T.; Prodhom, B.; Reiher, III,
//  !W.E.; Roux, B.; Schlenkrich, M.; Smith, J.C.; Stote, R.; Straub, J.;
//  !Watanabe, M.; Wiorkiewicz-Kuczera, J.; Yin, D.; Karplus, M.  All-atom
//  !empirical potential for molecular modeling and dynamics Studies of
//  !proteins.  Journal of Physical Chemistry B, 1998, 102, 3586-3616.
//  !
//  !PHOSPHOTYROSINE
//  !
//  !Feng, M.-H., Philippopoulos, M., MacKerell, Jr., A.D. and Lim, C.
//  !Structural Characterization of the Phosphotyrosine Binding Region of a
//  !High-Affinity aSH2 Domain-Phosphopeptide Complex by Molecular Dynamics
//  !Simulation and Chemical Shift Calculations. Journal of the American
//  !Chemical Society, 1996, 118: 11265-11277.
//  !
//  !IONS (see lipid and nucleic acid topology and parameter files for
//  !additional ions
//  !
//  !ZINC
//  !
//  !Roland H. Stote and Martin Karplus, Zinc Binding in Proteins and
//  !Solution: A Simple but Accurate Nonbonded Representation, PROTEINS:
//  !Structure, Function, and Genetics 23:12-31 (1995)
//  !
//  !references
//  !
//  !LIPIDS
//  !
//  !Feller, S. and MacKerell, Jr., A.D. manuscript in preparation
//  !
//  !and
//  !
//  !Schlenkrich, M., Brickmann, J., MacKerell, Jr., A.D., and Karplus, M.
//  !Empirical Potential Energy Function for Phospholipids: Criteria for
//  !Parameter Optimization and Applications, in "Biological Membranes: A
//  !Molecular Perspective from Computation and Experiment," K.M. Merz and
//  !B. Roux, Eds. Birkhauser, Boston, 1996, pp 31-81.
//  !
//  !new ALKANES
//  !
//  !Yin, D. and MacKerell, Jr. A.D. Combined Ab initio/Empirical Approach
//  !for the Optimization of Lennard-Jones Parameters. Journal of
//  !Computational Chemistry, 1998, 19: 334-338.
//  !
//  !ALKENES
//  !
//  !Feller, S.E., Yin, D., Pastor, R.W., and MacKerell, Jr., A.D.,
//  !Molecular Dynamics Simulation of Unsaturated Lipids at Low Hydration:
//  !Parameterization and Comparison with Diffraction Studies.  Biophysical
//  !Journal, 73:2269-2279, 1997.
//  !
//  !new PHOSPHATE
//  !
//  !MacKerell, Jr., A.D. Influence of Water and Sodium on the Energetics
//  !of Dimethylphosphate and its Implications For DNA Structure, Journal
//  !de Chimie Physique, 1997, 94: 1436-1447.
//  !
//  !IONS
//  !
//  !all ions from Roux and coworkers
//  !
//  !Sodium
//  !
//  !Beglov, D. and Roux, B., Finite Representation of an Infinite
//  !Bulk System: Solvent Boundary Potential for Computer Simulations,
//  !Journal of Chemical Physics, 1994, 100: 9050-9063
//  ! 
//  
//  MASS     1 H      1.00800 H ! polar H
//  MASS     2 HC     1.00800 H ! N-ter H
//  MASS     3 HA     1.00800 H ! nonpolar H
//  MASS     4 HT     1.00800 H ! TIPS3P WATER HYDROGEN
//  MASS     5 HP     1.00800 H ! aromatic H
//  MASS     6 HB     1.00800 H ! backbone H
//  MASS     7 HR1    1.00800 H ! his he1, (+) his HG,HD2
//  MASS     8 HR2    1.00800 H ! (+) his HE1
//  MASS     9 HR3    1.00800 H ! neutral his HG, HD2
//  MASS    10 HS     1.00800 H ! thiol hydrogen
//  MASS    11 HE1    1.00800 H ! for alkene; RHC=CR
//  MASS    12 HE2    1.00800 H ! for alkene; H2C=CR
//  MASS    20 C     12.01100 C ! carbonyl C, peptide backbone
//  MASS    21 CA    12.01100 C ! aromatic C
//  MASS    22 CT1   12.01100 C ! aliphatic sp3 C for CH
//  MASS    23 CT2   12.01100 C ! aliphatic sp3 C for CH2
//  MASS    24 CT3   12.01100 C ! aliphatic sp3 C for CH3
//  MASS    25 CPH1  12.01100 C ! his CG and CD2 carbons
//  MASS    26 CPH2  12.01100 C ! his CE1 carbon
//  MASS    27 CPT   12.01100 C ! trp C between rings
//  MASS    28 CY    12.01100 C ! TRP C in pyrrole ring
//  MASS    29 CP1   12.01100 C ! tetrahedral C (proline CA)
//  MASS    30 CP2   12.01100 C ! tetrahedral C (proline CB/CG)
//  MASS    31 CP3   12.01100 C ! tetrahedral C (proline CD)
//  MASS    32 CC    12.01100 C ! carbonyl C, asn,asp,gln,glu,cter,ct2
//  MASS    33 CD    12.01100 C ! carbonyl C, pres aspp,glup,ct1
//  MASS    34 CPA   12.01100 C ! heme alpha-C
//  MASS    35 CPB   12.01100 C ! heme beta-C
//  MASS    36 CPM   12.01100 C ! heme meso-C
//  MASS    37 CM    12.01100 C ! heme CO carbon
//  MASS    38 CS    12.01100 C ! thiolate carbon
//  MASS    39 CE1   12.01100 C ! for alkene; RHC=CR
//  MASS    40 CE2   12.01100 C ! for alkene; H2C=CR
//  MASS    50 N     14.00700 N ! proline N
//  MASS    51 NR1   14.00700 N ! neutral his protonated ring nitrogen
//  MASS    52 NR2   14.00700 N ! neutral his unprotonated ring nitrogen
//  MASS    53 NR3   14.00700 N ! charged his ring nitrogen
//  MASS    54 NH1   14.00700 N ! peptide nitrogen
//  MASS    55 NH2   14.00700 N ! amide nitrogen
//  MASS    56 NH3   14.00700 N ! ammonium nitrogen
//  MASS    57 NC2   14.00700 N ! guanidinium nitroogen
//  MASS    58 NY    14.00700 N ! TRP N in pyrrole ring
//  MASS    59 NP    14.00700 N ! Proline ring NH2+ (N-terminal)
//  MASS    60 NPH   14.00700 N ! heme pyrrole N
//  MASS    70 O     15.99900 O ! carbonyl oxygen
//  MASS    71 OB    15.99900 O ! carbonyl oxygen in acetic acid
//  MASS    72 OC    15.99900 O ! carboxylate oxygen
//  MASS    73 OH1   15.99900 O ! hydroxyl oxygen
//  MASS    74 OS    15.99940 O ! ester oxygen
//  MASS    75 OT    15.99940 O ! TIPS3P WATER OXYGEN
//  MASS    76 OM    15.99900 O ! heme CO/O2 oxygen
//  MASS    81 S     32.06000 S ! sulphur
//  MASS    82 SM    32.06000 S ! sulfur C-S-S-C type
//  MASS    83 SS    32.06000 S ! thiolate sulfur
//  MASS    85 HE     4.00260 HE ! helium
//  MASS    86 NE    20.17970 NE ! neon
//  MASS    90 CAL   40.08000 CA ! calcium 2+
//  MASS    91 ZN    65.37000 ZN ! zinc (II) cation
//  MASS    92 FE    55.84700 Fe ! heme iron 56
//  MASS    99 DUM    0.00000 H ! dummy atom
//  !lipids section
//  MASS 101    HL    1.008000 H ! polar H (equivalent to protein H)
//  MASS 102    HCL   1.008000 H ! charged H for PE (equivalent to protein HC)
//  !MASS 3    HT    1.008000 H ! TIPS3P WATER HYDROGEN
//  MASS 104    HOL   1.008000 H ! Nucleic acid phosphate hydroxyl proton
//  MASS 105    HAL1  1.008000 H ! alphatic proton
//  MASS 106    HAL2  1.008000 H ! alphatic proton
//  MASS 107    HAL3  1.008000 H ! alphatic proton
//  MASS 108    HEL1  1.008000 H ! for alkene; RHC=CR
//  MASS 109    HEL2  1.008000 H ! for alkene; H2C=CR
//  MASS 120   CL   12.011000 C ! carbonyl C (acetic acid/methyl acetate)
//  MASS 121   CTL1 12.011000 C ! sp3 carbon with 1 H  (-CH1-)
//  MASS 122   CTL2 12.011000 C ! carbon of methylene group (-CH2-)
//  MASS 123   CTL3 12.011000 C ! carbon of methyl group (-CH3)
//  MASS 124   CTL5 12.011000 C ! carbon of methyl group (-CH3) for tetramethylammonium
//  MASS 125   CEL1 12.011000 C ! for alkene; RHC=CR
//  MASS 126   CEL2 12.011000 C ! for alkene; H2C=CR
//  MASS 140   NTL  14.007000 N ! ammonium nitrogen
//  MASS 141   NH3L 14.007000 N ! nitrogen phosphatidylethanolamine
//  MASS 160   OBL  15.999400 O ! acetic acid carboxyl oxygen (e. to protein OB)
//  MASS 161   OCL  15.999400 O ! acetate oxygen
//  !MASS 162   OT   15.999400 O ! TIPS3P WATER OXYGEN
//  MASS 163   OSL  15.999400 O ! Nucleic acid phosphate ester oxygen
//  MASS 164   O2L  15.999400 O ! Nucleic acid =O in phosphate or sulfate
//  MASS 165   OHL  15.999400 O ! Nucleic acid phosphate hydroxyl oxygen
//  MASS 180   PL   30.974000 P ! phosphorus
//  MASS 185   SL   32.060000 S ! Sulfate sulfur
//  MASS 190   CLA  35.450000 CL ! CHLORIDE Anion
//  MASS 191   SOD  22.989770 NA ! Sodium Ion
//  MASS 192   MG   24.305000 MG ! Magnesium Ion
//  MASS 193   POT  39.102000 K ! Potassium Ion
//  !MASS 199   DUM   0.000000 H ! dummy atom
//  
//  DECL -CA  
//  DECL -C  
//  DECL -O  
//  DECL +N  
//  DECL +HN  
//  DECL +CA  
//  DEFA FIRS NTER LAST CTER   
//  AUTO ANGLES DIHE   
//  
//  RESI ALA          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |
//  ATOM HN   H       0.31  !  HN-N
//  ATOM CA   CT1     0.07  !     |     HB1
//  ATOM HA   HB      0.09  !     |    /
//  GROUP                   !  HA-CA--CB-HB2
//  ATOM CB   CT3    -0.27  !     |    \
//  ATOM HB1  HA      0.09  !     |     HB3
//  ATOM HB2  HA      0.09  !   O=C
//  ATOM HB3  HA      0.09  !     |
//  GROUP                   !
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  N  HN  N  CA  
//  BOND C  CA  C  +N  CA HA  CB HB1  CB HB2  CB HB3 
//  DOUBLE O  C 
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3551 126.4900  180.0000 115.4200  0.9996
//  IC -C   N    CA   C     1.3551 126.4900  180.0000 114.4400  1.5390
//  IC N    CA   C    +N    1.4592 114.4400  180.0000 116.8400  1.3558
//  IC +N   CA   *C   O     1.3558 116.8400  180.0000 122.5200  1.2297
//  IC CA   C    +N   +CA   1.5390 116.8400  180.0000 126.7700  1.4613
//  IC N    C    *CA  CB    1.4592 114.4400  123.2300 111.0900  1.5461
//  IC N    C    *CA  HA    1.4592 114.4400 -120.4500 106.3900  1.0840
//  IC C    CA   CB   HB1   1.5390 111.0900  177.2500 109.6000  1.1109
//  IC HB1  CA   *CB  HB2   1.1109 109.6000  119.1300 111.0500  1.1119
//  IC HB1  CA   *CB  HB3   1.1109 109.6000 -119.5800 111.6100  1.1114
//  
//  RESI ARG          1.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |                      HH11
//  ATOM HN   H       0.31  !  HN-N                       |
//  ATOM CA   CT1     0.07  !     |   HB1 HG1 HD1 HE     NH1-HH12
//  ATOM HA   HB      0.09  !     |   |   |   |   |    //(+)  
//  GROUP                   !  HA-CA--CB--CG--CD--NE--CZ
//  ATOM CB   CT2    -0.18  !     |   |   |   |         \
//  ATOM HB1  HA      0.09  !     |   HB2 HG2 HD2        NH2-HH22
//  ATOM HB2  HA      0.09  !   O=C                       |
//  GROUP                   !     |                      HH21
//  ATOM CG   CT2    -0.18
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  GROUP   
//  ATOM CD   CT2     0.20
//  ATOM HD1  HA      0.09
//  ATOM HD2  HA      0.09
//  ATOM NE   NC2    -0.70
//  ATOM HE   HC      0.44
//  ATOM CZ   C       0.64
//  ATOM NH1  NC2    -0.80
//  ATOM HH11 HC      0.46
//  ATOM HH12 HC      0.46
//  ATOM NH2  NC2    -0.80
//  ATOM HH21 HC      0.46
//  ATOM HH22 HC      0.46
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA  CG  CB  CD CG  NE CD  CZ NE   
//  BOND NH2 CZ  N  HN  N  CA   
//  BOND C   CA  C  +N  CA HA  CB HB1   
//  BOND CB  HB2 CG  HG1 CG HG2 CD HD1 CD HD2   
//  BOND NE  HE  NH1 HH11  NH1 HH12  NH2 HH21  NH2 HH22 
//  DOUBLE O  C    CZ  NH1  
//  IMPR N  -C  CA  HN   C CA +N O   
//  IMPR CZ NH1 NH2 NE
//  DONOR HN N   
//  DONOR HE NE   
//  DONOR HH11 NH1   
//  DONOR HH12 NH1   
//  DONOR HH21 NH2   
//  DONOR HH22 NH2   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3496 122.4500  180.0000 116.6700  0.9973
//  IC -C   N    CA   C     1.3496 122.4500  180.0000 109.8600  1.5227
//  IC N    CA   C    +N    1.4544 109.8600  180.0000 117.1200  1.3511
//  IC +N   CA   *C   O     1.3511 117.1200  180.0000 121.4000  1.2271
//  IC CA   C    +N   +CA   1.5227 117.1200  180.0000 124.6700  1.4565
//  IC N    C    *CA  CB    1.4544 109.8600  123.6400 112.2600  1.5552
//  IC N    C    *CA  HA    1.4544 109.8600 -117.9300 106.6100  1.0836
//  IC N    CA   CB   CG    1.4544 110.7000  180.0000 115.9500  1.5475
//  IC CG   CA   *CB  HB1   1.5475 115.9500  120.0500 106.4000  1.1163
//  IC CG   CA   *CB  HB2   1.5475 115.9500 -125.8100 109.5500  1.1124
//  IC CA   CB   CG   CD    1.5552 115.9500  180.0000 114.0100  1.5384
//  IC CD   CB   *CG  HG1   1.5384 114.0100  125.2000 108.5500  1.1121
//  IC CD   CB   *CG  HG2   1.5384 114.0100 -120.3000 108.9600  1.1143
//  IC CB   CG   CD   NE    1.5475 114.0100  180.0000 107.0900  1.5034
//  IC NE   CG   *CD  HD1   1.5034 107.0900  120.6900 109.4100  1.1143
//  IC NE   CG   *CD  HD2   1.5034 107.0900 -119.0400 111.5200  1.1150
//  IC CG   CD   NE   CZ    1.5384 107.0900  180.0000 123.0500  1.3401
//  IC CZ   CD   *NE  HE    1.3401 123.0500  180.0000 113.1400  1.0065
//  IC CD   NE   CZ   NH1   1.5034 123.0500  180.0000 118.0600  1.3311
//  IC NE   CZ   NH1  HH11  1.3401 118.0600 -178.2800 120.6100  0.9903
//  IC HH11 CZ   *NH1 HH12  0.9903 120.6100  171.1900 116.2900  1.0023
//  IC NH1  NE   *CZ  NH2   1.3311 118.0600  178.6400 122.1400  1.3292
//  IC NE   CZ   NH2  HH21  1.3401 122.1400 -174.1400 119.9100  0.9899
//  IC HH21 CZ   *NH2 HH22  0.9899 119.9100  166.1600 116.8800  0.9914 
//  
//  RESI ASN          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |       
//  ATOM HN   H       0.31  !  HN-N       
//  ATOM CA   CT1     0.07  !     |   HB1 OD1    HD21 (cis to OD1)
//  ATOM HA   HB      0.09  !     |   |   ||    /
//  GROUP                   !  HA-CA--CB--CG--ND2
//  ATOM CB   CT2    -0.18  !     |   |         \
//  ATOM HB1  HA      0.09  !     |   HB2        HD22 (trans to OD1)
//  ATOM HB2  HA      0.09  !   O=C           
//  GROUP                   !     |           
//  ATOM CG   CC      0.55
//  ATOM OD1  O      -0.55
//  GROUP   
//  ATOM ND2  NH2    -0.62
//  ATOM HD21 H       0.32
//  ATOM HD22 H       0.30
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  CG CB   ND2 CG   
//  BOND N  HN  N  CA   C   CA    C +N   
//  BOND CA HA  CB HB1  CB  HB2  ND2 HD21  ND2 HD22 
//  DOUBLE C  O   CG  OD1  
//  IMPR N   -C  CA   HN    C   CA +N   O   
//  IMPR CG  ND2 CB   OD1   CG  CB ND2  OD1   
//  IMPR ND2 CG  HD21 HD22  ND2 CG HD22 HD21   
//  DONOR HN N   
//  DONOR HD21 ND2   
//  DONOR HD22 ND2   
//  ACCEPTOR OD1 CG   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3480 124.0500  180.0000 114.4900  0.9992
//  IC -C   N    CA   C     1.3480 124.0500  180.0000 105.2300  1.5245
//  IC N    CA   C    +N    1.4510 105.2300  180.0000 117.3800  1.3467
//  IC +N   CA   *C   O     1.3467 117.3800  180.0000 120.3200  1.2282
//  IC CA   C    +N   +CA   1.5245 117.3800  180.0000 124.8800  1.4528
//  IC N    C    *CA  CB    1.4510 105.2300  121.1800 113.0400  1.5627
//  IC N    C    *CA  HA    1.4510 105.2300 -115.5200 107.6300  1.0848
//  IC N    CA   CB   CG    1.4510 110.9100  180.0000 114.3000  1.5319
//  IC CG   CA   *CB  HB1   1.5319 114.3000  119.1700 107.8200  1.1120
//  IC CG   CA   *CB  HB2   1.5319 114.3000 -123.7400 110.3400  1.1091
//  IC CA   CB   CG   OD1   1.5627 114.3000  180.0000 122.5600  1.2323
//  IC OD1  CB   *CG  ND2   1.2323 122.5600 -179.1900 116.1500  1.3521
//  IC CB   CG   ND2  HD21  1.5319 116.1500 -179.2600 117.3500  0.9963
//  IC HD21 CG   *ND2 HD22  0.9963 117.3500  178.0200 120.0500  0.9951
//  
//  RESI ASP         -1.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |       
//  ATOM HN   H       0.31  !  HN-N       
//  ATOM CA   CT1     0.07  !     |   HB1   OD1
//  ATOM HA   HB      0.09  !     |   |    //
//  GROUP                   !  HA-CA--CB--CG
//  ATOM CB   CT2    -0.28  !     |   |    \
//  ATOM HB1  HA      0.09  !     |   HB2   OD2(-)
//  ATOM HB2  HA      0.09  !   O=C           
//  ATOM CG   CC      0.62  !     |           
//  ATOM OD1  OC     -0.76
//  ATOM OD2  OC     -0.76
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  CG CB  OD2 CG   
//  BOND N  HN  N  CA   C   CA  C +N   
//  BOND CA HA  CB HB1  CB HB2   
//  DOUBLE  O   C   CG  OD1
//  IMPR N   -C CA  HN  C CA +N O   
//  !IMPR OD1 CB OD2 CG
//  IMPR CG  CB OD2 OD1
//  DONOR HN N   
//  ACCEPTOR OD1 CG   
//  ACCEPTOR OD2 CG   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3465 125.3100  180.0000 112.9400  0.9966
//  IC -C   N    CA   C     1.3465 125.3100  180.0000 105.6300  1.5315
//  IC N    CA   C    +N    1.4490 105.6300  180.0000 117.0600  1.3478
//  IC +N   CA   *C   O     1.3478 117.0600  180.0000 120.7100  1.2330
//  IC CA   C    +N   +CA   1.5315 117.0600  180.0000 125.3900  1.4484
//  IC N    C    *CA  CB    1.4490 105.6300  122.3300 114.1000  1.5619
//  IC N    C    *CA  HA    1.4490 105.6300 -116.4000 106.7700  1.0841
//  IC N    CA   CB   CG    1.4490 111.1000  180.0000 112.6000  1.5218
//  IC CG   CA   *CB  HB1   1.5218 112.6000  119.2200 109.2300  1.1086
//  IC CG   CA   *CB  HB2   1.5218 112.6000 -121.6100 110.6400  1.1080
//  IC CA   CB   CG   OD1   1.5619 112.6000  180.0000 117.9900  1.2565
//  IC OD1  CB   *CG  OD2   1.2565 117.9900 -170.2300 117.7000  1.2541
//  
//  RESI CYS          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |       
//  ATOM HN   H       0.31  !  HN-N       
//  ATOM CA   CT1     0.07  !     |   HB1
//  ATOM HA   HB      0.09  !     |   |  
//  GROUP                   !  HA-CA--CB--SG
//  ATOM CB   CT2    -0.11  !     |   |     \
//  ATOM HB1  HA      0.09  !     |   HB2    HG1
//  ATOM HB2  HA      0.09  !   O=C           
//  ATOM SG   S      -0.23  !     |           
//  ATOM HG1  HS      0.16
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA   SG CB   N HN  N  CA   
//  BOND C  CA   C +N  CA HA  CB HB1   
//  BOND CB HB2  SG HG1
//  DOUBLE O  C   
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HG1 SG   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3479 123.9300  180.0000 114.7700  0.9982
//  IC -C   N    CA   C     1.3479 123.9300  180.0000 105.8900  1.5202
//  IC N    CA   C    +N    1.4533 105.8900  180.0000 118.3000  1.3498
//  IC +N   CA   *C   O     1.3498 118.3000  180.0000 120.5900  1.2306
//  IC CA   C    +N   +CA   1.5202 118.3000  180.0000 124.5000  1.4548
//  IC N    C    *CA  CB    1.4533 105.8900  121.7900 111.9800  1.5584
//  IC N    C    *CA  HA    1.4533 105.8900 -116.3400 107.7100  1.0837
//  IC N    CA   CB   SG    1.4533 111.5600  180.0000 113.8700  1.8359
//  IC SG   CA   *CB  HB1   1.8359 113.8700  119.9100 107.2400  1.1134
//  IC SG   CA   *CB  HB2   1.8359 113.8700 -125.3200 109.8200  1.1124
//  IC CA   CB   SG   HG1   1.5584 113.8700  176.9600  97.1500  1.3341
//  
//  RESI GLN          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |          
//  ATOM HN   H       0.31  !  HN-N          
//  ATOM CA   CT1     0.07  !     |   HB1 HG1 OE1   HE21 (cis to OE1)
//  ATOM HA   HB      0.09  !     |   |   |   ||    /
//  GROUP                   !  HA-CA--CB--CG--CD--NE2
//  ATOM CB   CT2    -0.18  !     |   |   |         \
//  ATOM HB1  HA      0.09  !     |   HB2 HG2       HE22 (trans to OE1)
//  ATOM HB2  HA      0.09  !   O=C          
//  GROUP                   !     |          
//  ATOM CG   CT2    -0.18
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  GROUP   
//  ATOM CD   CC      0.55
//  ATOM OE1  O      -0.55
//  GROUP   
//  ATOM NE2  NH2    -0.62
//  ATOM HE21 H       0.32
//  ATOM HE22 H       0.30
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  CG  CB   CD  CG   NE2 CD   
//  BOND N  HN  N   CA   C   CA   
//  BOND C  +N  CA  HA   CB  HB1  CB  HB2  CG HG1   
//  BOND CG HG2 NE2 HE21 NE2 HE22   
//  DOUBLE O  C    CD  OE1  
//  IMPR N   -C  CA   HN    C   CA +N   O   
//  IMPR CD  NE2 CG   OE1   CD  CG NE2  OE1   
//  IMPR NE2 CD  HE21 HE22  NE2 CD HE22 HE21   
//  DONOR HN N   
//  DONOR HE21 NE2   
//  DONOR HE22 NE2   
//  ACCEPTOR OE1 CD   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3477 123.9300  180.0000 114.4500  0.9984
//  IC -C   N    CA   C     1.3477 123.9300  180.0000 106.5700  1.5180
//  IC N    CA   C    +N    1.4506 106.5700  180.0000 117.7200  1.3463
//  IC +N   CA   *C   O     1.3463 117.7200  180.0000 120.5900  1.2291
//  IC CA   C    +N   +CA   1.5180 117.7200  180.0000 124.3500  1.4461
//  IC N    C    *CA  CB    1.4506 106.5700  121.9100 111.6800  1.5538
//  IC N    C    *CA  HA    1.4506 106.5700 -116.8200 107.5300  1.0832
//  IC N    CA   CB   CG    1.4506 111.4400  180.0000 115.5200  1.5534
//  IC CG   CA   *CB  HB1   1.5534 115.5200  120.9300 106.8000  1.1147
//  IC CG   CA   *CB  HB2   1.5534 115.5200 -124.5800 109.3400  1.1140
//  IC CA   CB   CG   CD    1.5538 115.5200  180.0000 112.5000  1.5320
//  IC CD   CB   *CG  HG1   1.5320 112.5000  118.6900 110.4100  1.1112
//  IC CD   CB   *CG  HG2   1.5320 112.5000 -121.9100 110.7400  1.1094
//  IC CB   CG   CD   OE1   1.5534 112.5000  180.0000 121.5200  1.2294
//  IC OE1  CG   *CD  NE2   1.2294 121.5200  179.5700 116.8400  1.3530
//  IC CG   CD   NE2  HE21  1.5320 116.8400 -179.7200 116.8600  0.9959
//  IC HE21 CD   *NE2 HE22  0.9959 116.8600 -178.9100 119.8300  0.9943
//  
//  RESI GLU         -1.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |          
//  ATOM HN   H       0.31  !  HN-N          
//  ATOM CA   CT1     0.07  !     |   HB1 HG1   OE1
//  ATOM HA   HB      0.09  !     |   |   |    //
//  GROUP                   !  HA-CA--CB--CG--CD
//  ATOM CB   CT2    -0.18  !     |   |   |    \
//  ATOM HB1  HA      0.09  !     |   HB2 HG2   OE2(-)
//  ATOM HB2  HA      0.09  !   O=C          
//  GROUP                   !     |          
//  ATOM CG   CT2    -0.28
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  ATOM CD   CC      0.62
//  ATOM OE1  OC     -0.76
//  ATOM OE2  OC     -0.76
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  CG CB  CD CG  OE2 CD   
//  BOND N  HN  N  CA C   CA   
//  BOND C  +N  CA HA  CB HB1 CB  HB2 CG  HG1   
//  BOND CG HG2  
//  DOUBLE O  C   CD  OE1 
//  IMPR N   -C CA  HN  C CA +N O   
//  !IMPR OE1 CG OE2 CD
//  IMPR CD CG OE2 OE1
//  DONOR HN N   
//  ACCEPTOR OE1 CD   
//  ACCEPTOR OE2 CD   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3471 124.4500  180.0000 113.9900  0.9961
//  IC -C   N    CA   C     1.3471 124.4500  180.0000 107.2700  1.5216
//  IC N    CA   C    +N    1.4512 107.2700  180.0000 117.2500  1.3501
//  IC +N   CA   *C   O     1.3501 117.2500  180.0000 121.0700  1.2306
//  IC CA   C    +N   +CA   1.5216 117.2500  180.0000 124.3000  1.4530
//  IC N    C    *CA  CB    1.4512 107.2700  121.9000 111.7100  1.5516
//  IC N    C    *CA  HA    1.4512 107.2700 -118.0600 107.2600  1.0828
//  IC N    CA   CB   CG    1.4512 111.0400  180.0000 115.6900  1.5557
//  IC CG   CA   *CB  HB1   1.5557 115.6900  121.2200 108.1600  1.1145
//  IC CG   CA   *CB  HB2   1.5557 115.6900 -123.6500 109.8100  1.1131
//  IC CA   CB   CG   CD    1.5516 115.6900  180.0000 115.7300  1.5307
//  IC CD   CB   *CG  HG1   1.5307 115.7300  117.3800 109.5000  1.1053
//  IC CD   CB   *CG  HG2   1.5307 115.7300 -121.9600 111.0000  1.1081
//  IC CB   CG   CD   OE1   1.5557 115.7300  180.0000 114.9900  1.2590
//  IC OE1  CG   *CD  OE2   1.2590 114.9900 -179.1000 120.0800  1.2532
//  
//  RESI GLY          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |
//  ATOM HN   H       0.31  !     N-H
//  ATOM CA   CT2    -0.02  !     |  
//  ATOM HA1  HB      0.09  !     |  
//  ATOM HA2  HB      0.09  ! HA1-CA-HA2
//  GROUP                   !     |  
//  ATOM C    C       0.51  !     |  
//  ATOM O    O      -0.51  !     C=O
//                          !     |
//  BOND N HN  N  CA  C CA   
//  BOND C +N  CA HA1 CA HA2  
//  DOUBLE O  C 
//  IMPR N -C  CA HN  C CA   +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3475 122.8200  180.0000 115.6200  0.9992
//  IC -C   N    CA   C     1.3475 122.8200  180.0000 108.9400  1.4971
//  IC N    CA   C    +N    1.4553 108.9400  180.0000 117.6000  1.3479
//  IC +N   CA   *C   O     1.3479 117.6000  180.0000 120.8500  1.2289
//  IC CA   C    +N   +CA   1.4971 117.6000  180.0000 124.0800  1.4560
//  IC N    C    *CA  HA1   1.4553 108.9400  117.8600 108.0300  1.0814
//  IC N    C    *CA  HA2   1.4553 108.9400 -118.1200 107.9500  1.0817
//  PATCHING FIRS GLYP   
//  
//  RESI HSD          0.00  ! neutral HIS, proton on ND1
//  GROUP   
//  ATOM N    NH1    -0.47  !     |          HD1    HE1
//  ATOM HN   H       0.31  !  HN-N           |     /
//  ATOM CA   CT1     0.07  !     |   HB1    ND1--CE1
//  ATOM HA   HB      0.09  !     |   |     /      ||
//  GROUP                   !  HA-CA--CB--CG       ||
//  ATOM CB   CT2    -0.09  !     |   |     \\     ||
//  ATOM HB1  HA      0.09  !     |   HB2    CD2--NE2
//  ATOM HB2  HA      0.09  !   O=C           |
//  ATOM ND1  NR1    -0.36  !     |          HD2
//  ATOM HD1  H       0.32
//  ATOM CG   CPH1   -0.05
//  GROUP   
//  ATOM CE1  CPH2    0.25
//  ATOM HE1  HR1     0.13
//  ATOM NE2  NR2    -0.70
//  ATOM CD2  CPH1    0.22
//  ATOM HD2  HR3     0.10
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   ND1 CG   CE1 ND1   
//  BOND NE2 CD2  N   HN   N   CA   
//  BOND C   CA   C   +N   CA  HA   CB  HB1   
//  BOND CB  HB2  ND1 HD1  CD2 HD2  CE1 HE1  
//  DOUBLE O  C   CG  CD2   CE1  NE2 
//  IMPR ND1 CG CE1 HD1  CD2 CG  NE2 HD2  CE1 ND1 NE2 HE1   
//  IMPR ND1 CE1 CG HD1  CD2 NE2 CG  HD2  CE1 NE2 ND1 HE1   
//  IMPR N   -C  CA HN   C   CA  +N  O   
//  DONOR HN N   
//  DONOR HD1 ND1   
//  ACCEPTOR NE2   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3475 123.2700  180.0000 115.2100  0.9988
//  IC -C   N    CA   C     1.3475 123.2700  180.0000 107.7000  1.5166
//  IC N    CA   C    +N    1.4521 107.7000  180.0000 117.5700  1.3509
//  IC +N   CA   *C   O     1.3509 117.5700  180.0000 120.2400  1.2273
//  IC CA   C    +N   +CA   1.5166 117.5700  180.0000 123.7200  1.4545
//  IC N    C    *CA  CB    1.4521 107.7000  122.4600 109.9900  1.5519
//  IC N    C    *CA  HA    1.4521 107.7000 -117.4900 107.3700  1.0830
//  IC N    CA   CB   CG    1.4521 112.1200  180.0000 114.0500  1.5041
//  IC CG   CA   *CB  HB1   1.5041 114.0500  121.1700 109.0100  1.1118
//  IC CG   CA   *CB  HB2   1.5041 114.0500 -122.3600 109.5300  1.1121
//  IC CA   CB   CG   ND1   1.5519 114.0500   90.0000 124.1000  1.3783
//  IC ND1  CB   *CG  CD2   1.3783 124.1000 -171.2900 129.6000  1.3597
//  IC CB   CG   ND1  CE1   1.5041 124.1000 -173.2100 107.0300  1.3549
//  IC CB   CG   CD2  NE2   1.5041 129.6000  171.9900 110.0300  1.3817
//  IC NE2  ND1  *CE1 HE1   1.3166 111.6300 -179.6300 123.8900  1.0932
//  IC CE1  CG   *ND1 HD1   1.3549 107.0300 -174.6500 126.2600  1.0005
//  IC NE2  CG   *CD2 HD2   1.3817 110.0300 -177.8500 129.6300  1.0834
//  
//  RESI HSE          0.00  ! neutral His, proton on NE2
//  GROUP   
//  ATOM N    NH1    -0.47  !     |                 HE1
//  ATOM HN   H       0.31  !  HN-N             __  /
//  ATOM CA   CT1     0.07  !     |   HB1    ND1--CE1
//  ATOM HA   HB      0.09  !     |   |     /      |
//  GROUP                   !  HA-CA--CB--CG       |
//  ATOM CB   CT2    -0.08  !     |   |     \\     |
//  ATOM HB1  HA      0.09  !     |   HB2    CD2--NE2
//  ATOM HB2  HA      0.09  !   O=C           |     \
//  ATOM ND1  NR2    -0.70  !     |          HD2    HE2
//  ATOM CG   CPH1    0.22
//  ATOM CE1  CPH2    0.25
//  ATOM HE1  HR1     0.13
//  GROUP
//  ATOM NE2  NR1    -0.36
//  ATOM HE2  H       0.32
//  ATOM CD2  CPH1   -0.05
//  ATOM HD2  HR3     0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   ND1 CG     
//  BOND NE2 CD2  N   HN   N   CA      
//  BOND C   CA   C   +N   NE2 CE1  CA  HA   CB HB1   
//  BOND CB  HB2  NE2 HE2  CD2 HD2  CE1 HE1 
//  DOUBLE   O   C   CD2 CG   CE1 ND1
//  IMPR NE2 CD2 CE1 HE2  CD2 CG  NE2 HD2  CE1 ND1 NE2 HE1   
//  IMPR NE2 CE1 CD2 HE2  CD2 NE2 CG  HD2  CE1 NE2 ND1 HE1   
//  IMPR N   -C  CA  HN   C   CA  +N  O   
//  DONOR HN N   
//  DONOR HE2 NE2   
//  ACCEPTOR ND1   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3472 124.1600  180.0000 114.3600  0.9991
//  IC -C   N    CA   C     1.3472 124.1600  180.0000 106.4300  1.5166
//  IC N    CA   C    +N    1.4532 106.4300  180.0000 116.9700  1.3446
//  IC +N   CA   *C   O     1.3446 116.9700  180.0000 120.6800  1.2290
//  IC CA   C    +N   +CA   1.5166 116.9700  180.0000 124.9500  1.4505
//  IC N    C    *CA  CB    1.4532 106.4300  123.5200 111.6700  1.5578
//  IC N    C    *CA  HA    1.4532 106.4300 -116.4900 107.0800  1.0833
//  IC N    CA   CB   CG    1.4532 112.8200  180.0000 116.9400  1.5109
//  IC CG   CA   *CB  HB1   1.5109 116.9400  119.8000 107.9100  1.1114
//  IC CG   CA   *CB  HB2   1.5109 116.9400 -124.0400 109.5000  1.1101
//  IC CA   CB   CG   ND1   1.5578 116.9400   90.0000 120.1700  1.3859
//  IC ND1  CB   *CG  CD2   1.3859 120.1700 -178.2600 129.7100  1.3596
//  IC CB   CG   ND1  CE1   1.5109 120.1700 -179.2000 105.2000  1.3170
//  IC CB   CG   CD2  NE2   1.5109 129.7100  178.6600 105.8000  1.3782
//  IC NE2  ND1  *CE1 HE1   1.3539 111.7600  179.6900 124.5800  1.0929
//  IC CE1  CD2  *NE2 HE2   1.3539 107.1500 -178.6900 125.8600  0.9996
//  IC NE2  CG   *CD2 HD2   1.3782 105.8000 -179.3500 129.8900  1.0809
//  
//  RESI HSP          1.00  ! Protonated His
//  GROUP   
//  ATOM N    NH1    -0.47  !     |          HD1    HE1
//  ATOM HN   H       0.31  !  HN-N           |     /
//  ATOM CA   CT1     0.07  !     |   HB1    ND1--CE1
//  ATOM HA   HB      0.09  !     |   |     /      ||
//  GROUP                   !  HA-CA--CB--CG       ||
//  ATOM CB   CT2    -0.05  !     |   |     \\     ||
//  ATOM HB1  HA      0.09  !     |   HB2    CD2--NE2(+)
//  ATOM HB2  HA      0.09  !   O=C           |     \
//  ATOM CD2  CPH1    0.19  !     |          HD2    HE2
//  ATOM HD2  HR1     0.13
//  ATOM CG   CPH1    0.19
//  GROUP
//  ATOM NE2  NR3    -0.51
//  ATOM HE2  H       0.44
//  ATOM ND1  NR3    -0.51
//  ATOM HD1  H       0.44
//  ATOM CE1  CPH2    0.32
//  ATOM HE1  HR2     0.18
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   ND1 CG   CE1 ND1   
//  BOND NE2 CD2  N   HN   N   CA   
//  BOND C   CA   C   +N  CA  HA  CB HB1   
//  BOND CB  HB2  ND1 HD1  NE2 HE2  CD2 HD2 CE1 HE1
//  DOUBLE  O   C   CD2 CG     NE2 CE1
//  IMPR ND1 CG  CE1 HD1  ND1 CE1 CG  HD1
//  IMPR NE2 CD2 CE1 HE2  NE2 CE1 CD2 HE2   
//  IMPR N   -C  CA  HN   C   CA  +N  O   
//  DONOR HN N   
//  DONOR HD1 ND1   
//  DONOR HE2 NE2   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3489 123.9300  180.0000 118.8000  1.0041
//  IC -C   N    CA   C     1.3489 123.9300  180.0000 112.0300  1.5225
//  IC N    CA   C    +N    1.4548 112.0300  180.0000 116.4900  1.3464
//  IC +N   CA   *C   O     1.3464 116.4900  180.0000 121.2000  1.2284
//  IC CA   C    +N   +CA   1.5225 116.4900  180.0000 124.2400  1.4521
//  IC N    C    *CA  CB    1.4548 112.0300  125.1300 109.3800  1.5533
//  IC N    C    *CA  HA    1.4548 112.0300 -119.2000 106.7200  1.0832
//  IC N    CA   CB   CG    1.4548 112.2500  180.0000 114.1800  1.5168
//  IC CG   CA   *CB  HB1   1.5168 114.1800  122.5000 108.9900  1.1116
//  IC CG   CA   *CB  HB2   1.5168 114.1800 -121.5100 108.9700  1.1132
//  IC CA   CB   CG   ND1   1.5533 114.1800   90.0000 122.9400  1.3718
//  IC ND1  CB   *CG  CD2   1.3718 122.9400 -165.2600 128.9300  1.3549
//  IC CB   CG   ND1  CE1   1.5168 122.9400 -167.6200 108.9000  1.3262
//  IC CB   CG   CD2  NE2   1.5168 128.9300  167.1300 106.9300  1.3727
//  IC NE2  ND1  *CE1 HE1   1.3256 108.5000  178.3900 125.7600  1.0799
//  IC CE1  CD2  *NE2 HE2   1.3256 108.8200 -172.9400 125.5200  1.0020
//  IC CE1  CG   *ND1 HD1   1.3262 108.9000  171.4900 126.0900  1.0018
//  IC NE2  CG   *CD2 HD2   1.3727 106.9300 -174.4900 128.4100  1.0867
//  
//  RESI ILE          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |    HG21 HG22
//  ATOM HN   H       0.31  !  HN-N      | / 
//  ATOM CA   CT1     0.07  !     |     CG2--HG23
//  ATOM HA   HB      0.09  !     |    /
//  GROUP                   !  HA-CA--CB-HB    HD1
//  ATOM CB   CT1    -0.09  !     |    \       /
//  ATOM HB   HA      0.09  !     |     CG1--CD--HD2
//  GROUP                   !   O=C    / \     \	 
//  ATOM CG2  CT3    -0.27  !     | HG11 HG12  HD3
//  ATOM HG21 HA      0.09
//  ATOM HG22 HA      0.09
//  ATOM HG23 HA      0.09
//  GROUP   
//  ATOM CG1  CT2    -0.18
//  ATOM HG11 HA      0.09
//  ATOM HG12 HA      0.09
//  GROUP   
//  ATOM CD   CT3    -0.27
//  ATOM HD1  HA      0.09
//  ATOM HD2  HA      0.09
//  ATOM HD3  HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG1 CB   CG2 CB   CD  CG1   
//  BOND N   HN   N   CA    C   CA   C   +N   
//  BOND CA  HA   CB  HB   CG1 HG11 CG1 HG12 CG2 HG21   
//  BOND CG2 HG22 CG2 HG23 CD  HD1  CD  HD2  CD  HD3 
//  DOUBLE  O   C
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3470 124.1600  180.0000 114.1900  0.9978
//  IC -C   N    CA   C     1.3470 124.1600  180.0000 106.3500  1.5190
//  IC N    CA   C    +N    1.4542 106.3500  180.0000 117.9700  1.3465
//  IC +N   CA   *C   O     1.3465 117.9700  180.0000 120.5900  1.2300
//  IC CA   C    +N   +CA   1.5190 117.9700  180.0000 124.2100  1.4467
//  IC N    C    *CA  CB    1.4542 106.3500  124.2200 112.9300  1.5681
//  IC N    C    *CA  HA    1.4542 106.3500 -115.6300 106.8100  1.0826
//  IC N    CA   CB   CG1   1.4542 112.7900  180.0000 113.6300  1.5498
//  IC CG1  CA   *CB  HB    1.5498 113.6300  114.5500 104.4800  1.1195
//  IC CG1  CA   *CB  CG2   1.5498 113.6300 -130.0400 113.9300  1.5452
//  IC CA   CB   CG2  HG21  1.5681 113.9300 -171.3000 110.6100  1.1100
//  IC HG21 CB   *CG2 HG22  1.1100 110.6100  119.3500 110.9000  1.1102
//  IC HG21 CB   *CG2 HG23  1.1100 110.6100 -120.0900 110.9700  1.1105
//  IC CA   CB   CG1  CD    1.5681 113.6300  180.0000 114.0900  1.5381
//  IC CD   CB   *CG1 HG11  1.5381 114.0900  122.3600 109.7800  1.1130
//  IC CD   CB   *CG1 HG12  1.5381 114.0900 -120.5900 108.8900  1.1141
//  IC CB   CG1  CD   HD1   1.5498 114.0900 -176.7800 110.3100  1.1115
//  IC HD1  CG1  *CD  HD2   1.1115 110.3100  119.7500 110.6500  1.1113
//  IC HD1  CG1  *CD  HD3   1.1115 110.3100 -119.7000 111.0200  1.1103
//  
//  RESI LEU          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |        HD11 HD12
//  ATOM HN   H       0.31  !  HN-N          | /
//  ATOM CA   CT1     0.07  !     |   HB1   CD1--HD13
//  ATOM HA   HB      0.09  !     |   |    /
//  GROUP                   !  HA-CA--CB--CG-HG
//  ATOM CB   CT2    -0.18  !     |   |    \ 
//  ATOM HB1  HA      0.09  !     |   HB2   CD2--HD23
//  ATOM HB2  HA      0.09  !   O=C          | \
//  GROUP                   !     |        HD21 HD22
//  ATOM CG   CT1    -0.09
//  ATOM HG   HA      0.09
//  GROUP   
//  ATOM CD1  CT3    -0.27
//  ATOM HD11 HA      0.09
//  ATOM HD12 HA      0.09
//  ATOM HD13 HA      0.09
//  GROUP   
//  ATOM CD2  CT3    -0.27
//  ATOM HD21 HA      0.09
//  ATOM HD22 HA      0.09
//  ATOM HD23 HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   CD1 CG   CD2 CG   
//  BOND N   HN   N   CA    C   CA   C +N   
//  BOND CA  HA   CB  HB1  CB  HB2  CG  HG   CD1 HD11   
//  BOND CD1 HD12 CD1 HD13 CD2 HD21 CD2 HD22 CD2 HD23
//  DOUBLE   O   C
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3474 124.3100  180.0000 114.2600  0.9979
//  IC -C   N    CA   C     1.3474 124.3100  180.0000 106.0500  1.5184
//  IC N    CA   C    +N    1.4508 106.0500  180.0000 117.9300  1.3463
//  IC +N   CA   *C   O     1.3463 117.9300  180.0000 120.5600  1.2299
//  IC CA   C    +N   +CA   1.5184 117.9300  180.0000 124.2600  1.4467
//  IC N    C    *CA  CB    1.4508 106.0500  121.5200 112.1200  1.5543
//  IC N    C    *CA  HA    1.4508 106.0500 -116.5000 107.5700  1.0824
//  IC N    CA   CB   CG    1.4508 111.1900  180.0000 117.4600  1.5472
//  IC CG   CA   *CB  HB1   1.5472 117.4600  120.9800 107.1700  1.1145
//  IC CG   CA   *CB  HB2   1.5472 117.4600 -124.6700 108.9800  1.1126
//  IC CA   CB   CG   CD1   1.5543 117.4600  180.0000 110.4800  1.5361
//  IC CD1  CB   *CG  CD2   1.5361 110.4800 -123.7500 112.5700  1.5360
//  IC CD1  CD2  *CG  HG    1.5361 110.2600 -116.6300 108.0200  1.1168
//  !IC CD1  CB   *CG  HG    1.5361 110.4800  116.6300 108.6800  1.1168 old 
//  IC CB   CG   CD1  HD11  1.5472 110.4800  177.3300 110.5400  1.1111
//  IC HD11 CG   *CD1 HD12  1.1111 110.5400  119.9600 110.6200  1.1112
//  IC HD11 CG   *CD1 HD13  1.1111 110.5400 -119.8500 110.6900  1.1108
//  IC CB   CG   CD2  HD21  1.5472 112.5700  178.9600 110.3200  1.1116
//  IC HD21 CG   *CD2 HD22  1.1116 110.3200  119.7100 111.6900  1.1086
//  IC HD21 CG   *CD2 HD23  1.1116 110.3200 -119.6100 110.4900  1.1115
//  
//  RESI LYS          1.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |                   
//  ATOM HN   H       0.31  !  HN-N                   
//  ATOM CA   CT1     0.07  !     |   HB1 HG1 HD1 HE1    HZ1
//  ATOM HA   HB      0.09  !     |   |   |   |   |     /   
//  GROUP                   !  HA-CA--CB--CG--CD--CE--NZ--HZ2
//  ATOM CB   CT2    -0.18  !     |   |   |   |   |     \
//  ATOM HB1  HA      0.09  !     |   HB2 HG2 HD2 HE2    HZ3
//  ATOM HB2  HA      0.09  !   O=C                  
//  GROUP                   !     |                  
//  ATOM CG   CT2    -0.18
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  GROUP   
//  ATOM CD   CT2    -0.18
//  ATOM HD1  HA      0.09
//  ATOM HD2  HA      0.09
//  GROUP   
//  ATOM CE   CT2     0.21
//  ATOM HE1  HA      0.05
//  ATOM HE2  HA      0.05
//  ATOM NZ   NH3    -0.30
//  ATOM HZ1  HC      0.33
//  ATOM HZ2  HC      0.33
//  ATOM HZ3  HC      0.33
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA   CG CB   CD CG   CE CD   NZ CE   
//  BOND N  HN   N  CA    C  CA   
//  BOND C  +N   CA HA   CB HB1  CB HB2  CG HG1   
//  BOND CG HG2  CD HD1  CD HD2  CE HE1  CE HE2 
//  DOUBLE   O  C   
//  BOND NZ HZ1  NZ HZ2  NZ HZ3   
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HZ1 NZ   
//  DONOR HZ2 NZ   
//  DONOR HZ3 NZ   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3482 123.5700  180.0000 115.1100  0.9988
//  IC -C   N    CA   C     1.3482 123.5700  180.0000 107.2900  1.5187
//  IC N    CA   C    +N    1.4504 107.2900  180.0000 117.2700  1.3478
//  IC +N   CA   *C   O     1.3478 117.2700  180.0000 120.7900  1.2277
//  IC CA   C    +N   +CA   1.5187 117.2700  180.0000 124.9100  1.4487
//  IC N    C    *CA  CB    1.4504 107.2900  122.2300 111.3600  1.5568
//  IC N    C    *CA  HA    1.4504 107.2900 -116.8800 107.3600  1.0833
//  IC N    CA   CB   CG    1.4504 111.4700  180.0000 115.7600  1.5435
//  IC CG   CA   *CB  HB1   1.5435 115.7600  120.9000 107.1100  1.1146
//  IC CG   CA   *CB  HB2   1.5435 115.7600 -124.4800 108.9900  1.1131
//  IC CA   CB   CG   CD    1.5568 115.7600  180.0000 113.2800  1.5397
//  IC CD   CB   *CG  HG1   1.5397 113.2800  120.7400 109.1000  1.1138
//  IC CD   CB   *CG  HG2   1.5397 113.2800 -122.3400 108.9900  1.1143
//  IC CB   CG   CD   CE    1.5435 113.2800  180.0000 112.3300  1.5350
//  IC CE   CG   *CD  HD1   1.5350 112.3300  122.2500 108.4100  1.1141
//  IC CE   CG   *CD  HD2   1.5350 112.3300 -121.5900 108.1300  1.1146
//  IC CG   CD   CE   NZ    1.5397 112.3300  180.0000 110.4600  1.4604
//  IC NZ   CD   *CE  HE1   1.4604 110.4600  119.9100 110.5100  1.1128
//  IC NZ   CD   *CE  HE2   1.4604 110.4600 -120.0200 110.5700  1.1123
//  IC CD   CE   NZ   HZ1   1.5350 110.4600  179.9200 110.0200  1.0404
//  IC HZ1  CE   *NZ  HZ2   1.0404 110.0200  120.2700 109.5000  1.0402
//  IC HZ1  CE   *NZ  HZ3   1.0404 110.0200 -120.1300 109.4000  1.0401
//  
//  RESI MET          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |                   
//  ATOM HN   H       0.31  !  HN-N                   
//  ATOM CA   CT1     0.07  !     |   HB1 HG1     HE1 
//  ATOM HA   HB      0.09  !     |   |   |       |   
//  GROUP                   !  HA-CA--CB--CG--SD--CE--HE3
//  ATOM CB   CT2    -0.18  !     |   |   |       |   
//  ATOM HB1  HA      0.09  !     |   HB2 HG2     HE2 
//  ATOM HB2  HA      0.09  !   O=C                  
//  GROUP                   !     |                  
//  ATOM CG   CT2    -0.14
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  ATOM SD   S      -0.09
//  ATOM CE   CT3    -0.22
//  ATOM HE1  HA      0.09
//  ATOM HE2  HA      0.09
//  ATOM HE3  HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA   CG CB   SD CG   CE SD   
//  BOND N  HN   N  CA    C  CA   C  +N   
//  BOND CA HA   CB HB1  CB HB2  CG HG1  CG HG2   
//  BOND CE HE1  CE HE2  CE HE3  
//  DOUBLE   O  C   
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3478 124.2100  180.0000 114.3900  0.9978
//  IC -C   N    CA   C     1.3478 124.2100  180.0000 106.3100  1.5195
//  IC N    CA   C    +N    1.4510 106.3100  180.0000 117.7400  1.3471
//  IC +N   CA   *C   O     1.3471 117.7400  180.0000 120.6400  1.2288
//  IC CA   C    +N   +CA   1.5195 117.7400  180.0000 124.5200  1.4471
//  IC N    C    *CA  CB    1.4510 106.3100  121.6200 111.8800  1.5546
//  IC N    C    *CA  HA    1.4510 106.3100 -116.9800 107.5700  1.0832
//  IC N    CA   CB   CG    1.4510 111.2500  180.0000 115.9200  1.5460
//  IC CG   CA   *CB  HB1   1.5460 115.9200  120.5600 106.9000  1.1153
//  IC CG   CA   *CB  HB2   1.5460 115.9200 -124.8000 109.3800  1.1129
//  IC CA   CB   CG   SD    1.5546 115.9200  180.0000 110.2800  1.8219
//  IC SD   CB   *CG  HG1   1.8219 110.2800  120.5000 110.3400  1.1106
//  IC SD   CB   *CG  HG2   1.8219 110.2800 -121.1600 109.6400  1.1119
//  IC CB   CG   SD   CE    1.5460 110.2800  180.0000  98.9400  1.8206
//  IC CG   SD   CE   HE1   1.8219  98.9400 -179.4200 110.9100  1.1111
//  IC HE1  SD   *CE  HE2   1.1111 110.9100  119.9500 111.0300  1.1115
//  IC HE1  SD   *CE  HE3   1.1111 110.9100 -119.9500 111.0900  1.1112
//  
//  RESI PHE          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |        HD1  HE1    
//  ATOM HN   H       0.31  !  HN-N         |    |   
//  ATOM CA   CT1     0.07  !     |   HB1  CD1--CE1
//  ATOM HA   HB      0.09  !     |   |    //     \\
//  GROUP                   !  HA-CA--CB--CG      CZ--HZ
//  ATOM CB   CT2    -0.18  !     |   |    \  __  /
//  ATOM HB1  HA      0.09  !     |   HB2  CD2--CE2
//  ATOM HB2  HA      0.09  !   O=C         |    |  
//  GROUP                   !     |        HD2  HE2   
//  ATOM CG   CA      0.00
//  GROUP   
//  ATOM CD1  CA     -0.115
//  ATOM HD1  HP      0.115
//  GROUP   
//  ATOM CE1  CA     -0.115
//  ATOM HE1  HP      0.115
//  GROUP
//  ATOM CZ   CA     -0.115
//  ATOM HZ   HP      0.115
//  GROUP
//  ATOM CD2  CA     -0.115
//  ATOM HD2  HP      0.115
//  GROUP
//  ATOM CE2  CA     -0.115
//  ATOM HE2  HP      0.115
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG CB   CD2 CG   CE1 CD1   
//  BOND CZ  CE2  N   HN   
//  BOND N   CA    C   CA   C   +N   CA  HA   
//  BOND CB  HB1  CB HB2  CD1 HD1  CD2 HD2  CE1 HE1  
//  DOUBLE   O  C    CD1 CG  CZ CE1   CE2 CD2
//  BOND CE2 HE2  CZ HZ   
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3476 123.8900  180.0000 114.4700  0.9987
//  IC -C   N    CA   C     1.3476 123.8900  180.0000 106.3800  1.5229
//  IC N    CA   C    +N    1.4504 106.3800  180.0000 117.6500  1.3483
//  IC +N   CA   *C   O     1.3483 117.6500  180.0000 120.4900  1.2287
//  IC CA   C    +N   +CA   1.5229 117.6500  180.0000 124.1000  1.4523
//  IC N    C    *CA  CB    1.4504 106.3800  122.4900 112.4500  1.5594
//  IC N    C    *CA  HA    1.4504 106.3800 -115.6300 107.0500  1.0832
//  IC N    CA   CB   CG    1.4504 111.6300  180.0000 112.7600  1.5109
//  IC CG   CA   *CB  HB1   1.5109 112.7600  118.2700 109.1000  1.1119
//  IC CG   CA   *CB  HB2   1.5109 112.7600 -123.8300 111.1100  1.1113
//  IC CA   CB   CG   CD1   1.5594 112.7600   90.0000 120.3200  1.4059
//  IC CD1  CB   *CG  CD2   1.4059 120.3200 -177.9600 120.7600  1.4062
//  IC CB   CG   CD1  CE1   1.5109 120.3200 -177.3700 120.6300  1.4006
//  IC CE1  CG   *CD1 HD1   1.4006 120.6300  179.7000 119.6500  1.0814
//  IC CB   CG   CD2  CE2   1.5109 120.7600  177.2000 120.6200  1.4002
//  IC CE2  CG   *CD2 HD2   1.4002 120.6200 -178.6900 119.9900  1.0811
//  IC CG   CD1  CE1  CZ    1.4059 120.6300   -0.1200 119.9300  1.4004
//  IC CZ   CD1  *CE1 HE1   1.4004 119.9300 -179.6900 120.0100  1.0808
//  IC CZ   CD2  *CE2 HE2   1.4000 119.9600 -179.9300 119.8700  1.0811
//  IC CE1  CE2  *CZ  HZ    1.4004 119.9800  179.5100 119.9700  1.0807
//  
//  RESI PRO          0.00
//  GROUP                   !       HD1 HD2
//  ATOM N    N      -0.29  !     |   \ /
//  ATOM CD   CP3     0.00  !     N---CD   HG1  ATOM CA   CP1     0.02
//  ATOM HD1  HA      0.09  !     |     \  /
//  ATOM HD2  HA      0.09  !     |      CG
//  ATOM CA   CP1     0.02  !     |     /  \
//  ATOM HA   HB      0.09  !  HA-CA--CB   HG2
//  GROUP                   !     |   / \
//  ATOM CB   CP2    -0.18  !     | HB1 HB2
//  ATOM HB1  HA      0.09  !   O=C
//  ATOM HB2  HA      0.09  !     |
//  GROUP
//  ATOM CG   CP2    -0.18
//  ATOM HG1  HA      0.09
//  ATOM HG2  HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND C  CA  C   +N   
//  BOND N  CA  CA  CB  CB  CG  CG  CD  N   CD   
//  BOND HA CA  HG1 CG  HG2 CG  HD1 CD  HD2 CD  HB1 CB  HB2 CB
//  DOUBLE   O  C       
//  IMPR N -C CA CD   
//  IMPR C CA +N O   
//  ACCEPTOR O C   
//  IC -C   CA   *N   CD    1.3366 122.9400  178.5100 112.7500  1.4624
//  IC -C   N    CA   C     1.3366 122.9400  -76.1200 110.8600  1.5399
//  IC N    CA   C    +N    1.4585 110.8600  180.0000 114.7500  1.3569
//  IC +N   CA   *C   O     1.3569 114.7500  177.1500 120.4600  1.2316
//  IC CA   C    +N   +CA   1.5399 116.1200  180.0000 124.8900  1.4517
//  IC N    C    *CA  CB    1.4585 110.8600  113.7400 111.7400  1.5399
//  IC N    C    *CA  HA    1.4585 110.8600 -122.4000 109.0900  1.0837
//  IC N    CA   CB   CG    1.4585 102.5600   31.6100 104.3900  1.5322
//  IC CA   CB   CG   CD    1.5399 104.3900  -34.5900 103.2100  1.5317
//  IC N    CA   CB   HB1   1.4585 102.5600  -84.9400 109.0200  1.1131
//  IC N    CA   CB   HB2   1.4585 102.5600  153.9300 112.7400  1.1088
//  IC CA   CB   CG   HG1   1.5399 104.3900 -156.7200 112.9500  1.1077
//  IC CA   CB   CG   HG2   1.5399 104.3900   81.2600 109.2200  1.1143
//  IC CB   CG   CD   HD1   1.5322 103.2100  -93.5500 110.0300  1.1137
//  IC CB   CG   CD   HD2   1.5322 103.2100  144.5200 110.0000  1.1144
//  PATCHING FIRS PROP   
//  
//  RESI SER          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |       
//  ATOM HN   H       0.31  !  HN-N       
//  ATOM CA   CT1     0.07  !     |   HB1
//  ATOM HA   HB      0.09  !     |   |  
//  GROUP                   !  HA-CA--CB--OG
//  ATOM CB   CT2     0.05  !     |   |     \
//  ATOM HB1  HA      0.09  !     |   HB2    HG1
//  ATOM HB2  HA      0.09  !   O=C           
//  ATOM OG   OH1    -0.66  !     |           
//  ATOM HG1  H       0.43
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA   OG CB  N HN  N  CA   
//  BOND C  CA  C +N  CA HA  CB HB1   
//  BOND CB HB2  OG HG1  
//  DOUBLE   O  C      
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HG1 OG   
//  ACCEPTOR OG   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3474 124.3700  180.0000 114.1800  0.9999
//  IC -C   N    CA   C     1.3474 124.3700  180.0000 105.8100  1.5166
//  IC N    CA   C    +N    1.4579 105.8100  180.0000 117.7200  1.3448
//  IC +N   CA   *C   O     1.3448 117.7200  180.0000 120.2500  1.2290
//  IC CA   C    +N   +CA   1.5166 117.7200  180.0000 124.6300  1.4529
//  IC N    C    *CA  CB    1.4579 105.8100  124.7500 111.4000  1.5585
//  IC N    C    *CA  HA    1.4579 105.8100 -115.5600 107.3000  1.0821
//  IC N    CA   CB   OG    1.4579 114.2800  180.0000 112.4500  1.4341
//  IC OG   CA   *CB  HB1   1.4341 112.4500  119.3200 108.1000  1.1140
//  IC OG   CA   *CB  HB2   1.4341 112.4500 -123.8600 110.3800  1.1136
//  IC CA   CB   OG   HG1   1.5585 112.4500  165.9600 107.0800  0.9655
//  
//  RESI THR          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |  
//  ATOM HN   H       0.31  !  HN-N  
//  ATOM CA   CT1     0.07  !     |     OG1--HG1
//  ATOM HA   HB      0.09  !     |    /
//  GROUP                   !  HA-CA--CB-HB  
//  ATOM CB   CT1     0.14  !     |    \     
//  ATOM HB   HA      0.09  !     |     CG2--HG21
//  ATOM OG1  OH1    -0.66  !   O=C    / \    
//  ATOM HG1  H       0.43  !     | HG21 HG22 
//  GROUP                 
//  ATOM CG2  CT3    -0.27
//  ATOM HG21 HA      0.09
//  ATOM HG22 HA      0.09
//  ATOM HG23 HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB CA  OG1 CB   CG2 CB    N   HN   
//  BOND N  CA    C   CA    C   +N    CA  HA   
//  BOND CB HB  OG1 HG1  CG2 HG21  CG2 HG22  CG2 HG23
//  DOUBLE  O   C    
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HG1 OG1   
//  ACCEPTOR OG1   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3471 124.1200  180.0000 114.2600  0.9995
//  IC -C   N    CA   C     1.3471 124.1200  180.0000 106.0900  1.5162
//  IC N    CA   C    +N    1.4607 106.0900  180.0000 117.6900  1.3449
//  IC +N   CA   *C   O     1.3449 117.6900  180.0000 120.3000  1.2294
//  IC CA   C    +N   +CA   1.5162 117.6900  180.0000 124.6600  1.4525
//  IC N    C    *CA  CB    1.4607 106.0900  126.4600 112.7400  1.5693
//  IC N    C    *CA  HA    1.4607 106.0900 -114.9200 106.5300  1.0817
//  IC N    CA   CB   OG1   1.4607 114.8100  180.0000 112.1600  1.4252
//  IC OG1  CA   *CB  HB    1.4252 112.1600  116.3900 106.1100  1.1174
//  IC OG1  CA   *CB  CG2   1.4252 112.1600 -124.1300 115.9100  1.5324
//  IC CA   CB   OG1  HG1   1.5693 112.1600 -179.2800 105.4500  0.9633
//  IC CA   CB   CG2  HG21  1.5693 115.9100 -173.6500 110.8500  1.1104
//  IC HG21 CB   *CG2 HG22  1.1104 110.8500  119.5100 110.4100  1.1109
//  IC HG21 CB   *CG2 HG23  1.1104 110.8500 -120.3900 111.1100  1.1113
//  
//  RESI TRP          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |                  HE3
//  ATOM HN   H       0.31  !  HN-N                   |
//  ATOM CA   CT1     0.07  !     |   HB1            CE3
//  ATOM HA   HB      0.09  !     |   |             /  \\
//  GROUP                   !  HA-CA--CB---CG-----CD2   CZ3-HZ3
//  ATOM CB   CT2    -0.18  !     |   |    ||     ||     |
//  ATOM HB1  HA      0.09  !     |   HB2  CD1    CE2   CH2-HH2
//  ATOM HB2  HA      0.09  !   O=C       /   \   / \  //
//  GROUP                   !     |     HD1    NE1   CZ2
//  ATOM CG   CY     -0.03  !                   |     |
//  ATOM CD1  CA      0.035 !                  HE1   HZ2
//  ATOM HD1  HP      0.115
//  ATOM NE1  NY     -0.61
//  ATOM HE1  H       0.38
//  ATOM CE2  CPT     0.13
//  ATOM CD2  CPT    -0.02
//  GROUP
//  ATOM CE3  CA     -0.115
//  ATOM HE3  HP      0.115
//  GROUP
//  ATOM CZ3  CA     -0.115
//  ATOM HZ3  HP      0.115
//  GROUP
//  ATOM CZ2  CA     -0.115
//  ATOM HZ2  HP      0.115
//  GROUP
//  ATOM CH2  CA     -0.115
//  ATOM HH2  HP      0.115
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   CD2 CG   NE1 CD1   
//  BOND CZ2 CE2   
//  BOND N   HN   N   CA     C   CA   C   +N   
//  BOND CZ3 CH2  CD2 CE3  NE1 CE2  CA  HA   CB  HB1   
//  BOND CB  HB2  CD1 HD1  NE1 HE1  CE3 HE3  CZ2 HZ2   
//  BOND CZ3 HZ3  CH2 HH2
//  DOUBLE  O   C   CD1 CG   CE2 CD2  CZ3 CE3  CH2 CZ2     
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HE1 NE1   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3482 123.5100  180.0000 115.0200  0.9972
//  IC -C   N    CA   C     1.3482 123.5100  180.0000 107.6900  1.5202
//  IC N    CA   C    +N    1.4507 107.6900  180.0000 117.5700  1.3505
//  IC +N   CA   *C   O     1.3505 117.5700  180.0000 121.0800  1.2304
//  IC CA   C    +N   +CA   1.5202 117.5700  180.0000 124.8800  1.4526
//  IC N    C    *CA  CB    1.4507 107.6900  122.6800 111.2300  1.5560
//  IC N    C    *CA  HA    1.4507 107.6900 -117.0200 106.9200  1.0835
//  IC N    CA   CB   CG    1.4507 111.6800  180.0000 115.1400  1.5233
//  IC CG   CA   *CB  HB1   1.5233 115.1400  119.1700 107.8400  1.1127
//  IC CG   CA   *CB  HB2   1.5233 115.1400 -124.7300 109.8700  1.1118
//  IC CA   CB   CG   CD2   1.5560 115.1400   90.0000 123.9500  1.4407
//  IC CD2  CB   *CG  CD1   1.4407 123.9500 -172.8100 129.1800  1.3679
//  IC CD1  CG   CD2  CE2   1.3679 106.5700   -0.0800 106.6500  1.4126
//  IC CG   CD2  CE2  NE1   1.4407 106.6500    0.1400 107.8700  1.3746
//  IC CE2  CG   *CD2 CE3   1.4126 106.6500  179.2100 132.5400  1.4011
//  IC CE2  CD2  CE3  CZ3   1.4126 120.8000   -0.2000 118.1600  1.4017
//  IC CD2  CE3  CZ3  CH2   1.4011 118.1600    0.1000 120.9700  1.4019
//  IC CE3  CZ3  CH2  CZ2   1.4017 120.9700    0.0100 120.8700  1.4030
//  IC CZ3  CD2  *CE3 HE3   1.4017 118.1600 -179.6200 121.8400  1.0815
//  IC CH2  CE3  *CZ3 HZ3   1.4019 120.9700 -179.8200 119.4500  1.0811
//  IC CZ2  CZ3  *CH2 HH2   1.4030 120.8700 -179.9200 119.5700  1.0811
//  IC CE2  CH2  *CZ2 HZ2   1.3939 118.4200  179.8700 120.0800  1.0790
//  IC CD1  CE2  *NE1 HE1   1.3752 108.8100  177.7800 124.6800  0.9767
//  IC CG   NE1  *CD1 HD1   1.3679 110.1000  178.1000 125.4300  1.0820
//  
//  RESI TYR          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |        HD1  HE1    
//  ATOM HN   H       0.31  !  HN-N         |    |   
//  ATOM CA   CT1     0.07  !     |   HB1  CD1--CE1
//  ATOM HA   HB      0.09  !     |   |   //      \\
//  GROUP                   !  HA-CA--CB--CG      CZ--OH
//  ATOM CB   CT2    -0.18  !     |   |    \  __  /     \
//  ATOM HB1  HA      0.09  !     |   HB2  CD2--CE2     HH
//  ATOM HB2  HA      0.09  !   O=C         |    |  
//  GROUP                   !     |        HD2  HE2   
//  ATOM CG   CA      0.00
//  GROUP   
//  ATOM CD1  CA     -0.115
//  ATOM HD1  HP      0.115
//  GROUP   
//  ATOM CE1  CA     -0.115
//  ATOM HE1  HP      0.115
//  GROUP
//  ATOM CZ   CA      0.11
//  ATOM OH   OH1    -0.54
//  ATOM HH   H       0.43
//  GROUP
//  ATOM CD2  CA     -0.115
//  ATOM HD2  HP      0.115
//  GROUP
//  ATOM CE2  CA     -0.115
//  ATOM HE2  HP      0.115
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA   CG  CB   CD2 CG   CE1 CD1   
//  BOND CZ  CE2  OH  CZ   
//  BOND N   HN   N   CA    C   CA   C   +N   
//  BOND CA  HA   CB  HB1  CB  HB2  CD1 HD1  CD2 HD2   
//  BOND CE1 HE1  CE2 HE2  OH  HH
//  DOUBLE   O   C   CD1 CG  CE1  CZ  CE2 CD2      
//  IMPR N -C CA HN  C CA +N O   
//  DONOR HN N   
//  DONOR HH OH   
//  ACCEPTOR OH   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3476 123.8100  180.0000 114.5400  0.9986
//  IC -C   N    CA   C     1.3476 123.8100  180.0000 106.5200  1.5232
//  IC N    CA   C    +N    1.4501 106.5200  180.0000 117.3300  1.3484
//  IC +N   CA   *C   O     1.3484 117.3300  180.0000 120.6700  1.2287
//  IC CA   C    +N   +CA   1.5232 117.3300  180.0000 124.3100  1.4513
//  IC N    C    *CA  CB    1.4501 106.5200  122.2700 112.3400  1.5606
//  IC N    C    *CA  HA    1.4501 106.5200 -116.0400 107.1500  1.0833
//  IC N    CA   CB   CG    1.4501 111.4300  180.0000 112.9400  1.5113
//  IC CG   CA   *CB  HB1   1.5113 112.9400  118.8900 109.1200  1.1119
//  IC CG   CA   *CB  HB2   1.5113 112.9400 -123.3600 110.7000  1.1115
//  IC CA   CB   CG   CD1   1.5606 112.9400   90.0000 120.4900  1.4064
//  IC CD1  CB   *CG  CD2   1.4064 120.4900 -176.4600 120.4600  1.4068
//  IC CB   CG   CD1  CE1   1.5113 120.4900 -175.4900 120.4000  1.4026
//  IC CE1  CG   *CD1 HD1   1.4026 120.4000  178.9400 119.8000  1.0814
//  IC CB   CG   CD2  CE2   1.5113 120.4600  175.3200 120.5600  1.4022
//  IC CE2  CG   *CD2 HD2   1.4022 120.5600 -177.5700 119.9800  1.0813
//  IC CG   CD1  CE1  CZ    1.4064 120.4000   -0.1900 120.0900  1.3978
//  IC CZ   CD1  *CE1 HE1   1.3978 120.0900  179.6400 120.5800  1.0799
//  IC CZ   CD2  *CE2 HE2   1.3979 119.9200 -178.6900 119.7600  1.0798
//  IC CE1  CE2  *CZ  OH    1.3978 120.0500 -178.9800 120.2500  1.4063
//  IC CE1  CZ   OH   HH    1.3978 119.6800  175.4500 107.4700  0.9594
//  
//  RESI VAL          0.00
//  GROUP   
//  ATOM N    NH1    -0.47  !     |    HG11 HG12
//  ATOM HN   H       0.31  !  HN-N      | / 
//  ATOM CA   CT1     0.07  !     |     CG1--HG13
//  ATOM HA   HB      0.09  !     |    /
//  GROUP                   !  HA-CA--CB-HB  
//  ATOM CB   CT1    -0.09  !     |    \     
//  ATOM HB   HA      0.09  !     |     CG2--HG21
//  GROUP                   !   O=C    / \   
//  ATOM CG1  CT3    -0.27  !     | HG21 HG22
//  ATOM HG11 HA      0.09
//  ATOM HG12 HA      0.09
//  ATOM HG13 HA      0.09
//  GROUP   
//  ATOM CG2  CT3    -0.27
//  ATOM HG21 HA      0.09
//  ATOM HG22 HA      0.09
//  ATOM HG23 HA      0.09
//  GROUP   
//  ATOM C    C       0.51
//  ATOM O    O      -0.51
//  BOND CB  CA    CG1 CB    CG2 CB    N   HN   
//  BOND N   CA     C   CA    C   +N    CA HA   
//  BOND CB  HB    CG1 HG11  CG1 HG12  CG1 HG13  CG2 HG21   
//  BOND CG2 HG22  CG2 HG23
//  DOUBLE    O   C   
//  IMPR N -C CA HN C CA +N O   
//  DONOR HN N   
//  ACCEPTOR O C   
//  IC -C   CA   *N   HN    1.3482 124.5700  180.0000 114.4100  0.9966
//  IC -C   N    CA   C     1.3482 124.5700  180.0000 105.5400  1.5180
//  IC N    CA   C    +N    1.4570 105.5400  180.0000 117.8300  1.3471
//  IC +N   CA   *C   O     1.3471 117.8300  180.0000 120.7000  1.2297
//  IC CA   C    +N   +CA   1.5180 117.8300  180.0000 124.0800  1.4471
//  IC N    C    *CA  CB    1.4570 105.5400  122.9500 111.2300  1.5660
//  IC N    C    *CA  HA    1.4570 105.5400 -117.2400 107.4600  1.0828
//  IC N    CA   CB   CG1   1.4570 113.0500  180.0000 113.9700  1.5441
//  IC CG1  CA   *CB  CG2   1.5441 113.9700  123.9900 112.1700  1.5414
//  IC CG1  CA   *CB  HB    1.5441 113.9700 -119.1700 107.5700  1.1178
//  IC CA   CB   CG1  HG11  1.5660 113.9700  177.8300 110.3000  1.1114
//  IC HG11 CB   *CG1 HG12  1.1114 110.3000  119.2500 111.6700  1.1097
//  IC HG11 CB   *CG1 HG13  1.1114 110.3000 -119.4900 110.7000  1.1110
//  IC CA   CB   CG2  HG21  1.5660 112.1700 -177.7800 110.7100  1.1108
//  IC HG21 CB   *CG2 HG22  1.1108 110.7100  120.0800 110.5600  1.1115
//  IC HG21 CB   *CG2 HG23  1.1108 110.7100 -119.5500 111.2300  1.1098
//  
//  RESI TIP3         0.000 ! tip3p water model, generate using noangle nodihedral
//  GROUP   
//  ATOM OH2  OT     -0.834
//  ATOM H1   HT      0.417
//  ATOM H2   HT      0.417
//  !BOND OH2 H1 OH2 H2 H1 H2    ! the last bond is needed for shake
//  BOND OH2 H1 OH2 H2 
//  ANGLE H1 OH2 H2             ! required
//  ACCEPTOR OH2   
//  PATCHING FIRS NONE LAST NONE 
//  
//  RESI TP3M         0.000 ! "mmff" water model, as an analog of tip3p
//  GROUP   
//  ATOM OH2  OT     -0.834  ! these charges are replaced by the mmff setup   
//  ATOM H1   HT      0.417  ! these charges are replaced by the mmff setup
//  ATOM H2   HT      0.417  ! these charges are replaced by the mmff setup
//  BOND OH2 H1 OH2 H2          ! omits the H1-H2 bond, which is needed for shake with tip3p
//  ANGLE H1 OH2 H2             ! required
//  ACCEPTOR OH2   
//  PATCHING FIRS NONE LAST NONE     
//  
//  RESI CAL          2.00 ! Calcium ion
//  GROUP   
//  ATOM CAL  CAL     2.00
//  PATCHING FIRST NONE LAST NONE   
//  
//  RESI ZN2          2.00 ! Zinc ion
//  GROUP   
//  ATOM ZN   ZN      2.00
//  PATCHING FIRST NONE LAST NONE   
//  
//  RESI HEME        -2.00 ! 6-liganded planar heme
//  GROUP   
//  ATOM FE   FE      0.24 !       O2A   O1A             O2D  O1D
//  ATOM NA   NPH    -0.18 !         \\ //                 \\ //
//  ATOM NB   NPH    -0.18 !          CGA                   CGD
//  ATOM NC   NPH    -0.18 !           |                     |
//  ATOM ND   NPH    -0.18 !    HBA1--CBA--HBA2  HA   HBD1--CBD--HBD2
//  ATOM C1A  CPA     0.12 !           |          |          |
//  ATOM C2A  CPB    -0.06 !    HAA1--CAA-HAA2  _CHA_ HAD1--CAD--HAD2
//  ATOM C3A  CPB    -0.06 !           |       /     \       |
//  ATOM C4A  CPA     0.12 !          C2A---C1A       C4D---C3D
//  ATOM C1B  CPA     0.12 !           |     |         |     |
//  ATOM C2B  CPB    -0.06 !HMA1\      |     |         |     |      /HMD1
//  ATOM C3B  CPB    -0.06 !HMA2-CMA--C3A    NA       ND    C2D--CMD-HMD2
//  ATOM C4B  CPA     0.12 !HMA3/       \   / \       / \   /       \HMD3
//  ATOM C1C  CPA     0.12 !             C4A   \     /   C1D
//  ATOM C2C  CPB    -0.06 !            /       \   /       \
//  ATOM C3C  CPB    -0.06 !      HB--CHB        FE         CHD--HD
//  ATOM C4C  CPA     0.12 !            \       /   \       /
//  ATOM C1D  CPA     0.12 !             C1B   /     \   C4C        HAC
//  ATOM C2D  CPB    -0.06 !HMB1\       /   \ /       \ /   \       /
//  ATOM C3D  CPB    -0.06 !HMB2-CMB--C2B    NB       NC    C3C--CAC
//  ATOM C4D  CPA     0.12 !HMB3/      |     |         |     |     \\  /HBC1
//  GROUP                  !           |     |         |     |      CBC
//  ATOM CHA  CPM    -0.10 !          C3B---C4B       C1C---C2C        \HBC2
//  ATOM HA   HA      0.10 !           |       \_CHC_/       |
//  GROUP                  !          CAB         |         CMC--HMC3
//  ATOM CHB  CPM    -0.10 !         //  \        HC       /  | 
//  ATOM HB   HA      0.10 !        CBB  HAB           HMC1  HMC2
//  GROUP                  !       /   \
//  ATOM CHC  CPM    -0.10 !    HBB1  HBB2
//  ATOM HC   HA      0.10 !
//  GROUP   
//  ATOM CHD  CPM    -0.10
//  ATOM HD   HA      0.10
//  GROUP   
//  ATOM CMA  CT3    -0.27
//  ATOM HMA1 HA      0.09
//  ATOM HMA2 HA      0.09
//  ATOM HMA3 HA      0.09
//  GROUP   
//  ATOM CAA  CT2    -0.18
//  ATOM HAA1 HA      0.09
//  ATOM HAA2 HA      0.09
//  GROUP   
//  ATOM CBA  CT2    -0.28
//  ATOM HBA1 HA      0.09
//  ATOM HBA2 HA      0.09
//  ATOM CGA  CC      0.62
//  ATOM O1A  OC     -0.76
//  ATOM O2A  OC     -0.76
//  GROUP   
//  ATOM CMB  CT3    -0.27
//  ATOM HMB1 HA      0.09
//  ATOM HMB2 HA      0.09
//  ATOM HMB3 HA      0.09
//  GROUP   
//  ATOM CAB  C      -0.20
//  ATOM HAB  HA      0.20
//  GROUP   
//  ATOM CBB  C      -0.20
//  ATOM HBB1 HA      0.10
//  ATOM HBB2 HA      0.10
//  GROUP   
//  ATOM CMC  CT3    -0.27
//  ATOM HMC1 HA      0.09
//  ATOM HMC2 HA      0.09
//  ATOM HMC3 HA      0.09
//  GROUP   
//  ATOM CAC  C      -0.20
//  ATOM HAC  HA      0.20
//  GROUP   
//  ATOM CBC  C      -0.20
//  ATOM HBC1 HA      0.10
//  ATOM HBC2 HA      0.10
//  GROUP   
//  ATOM CMD  CT3    -0.27
//  ATOM HMD1 HA      0.09
//  ATOM HMD2 HA      0.09
//  ATOM HMD3 HA      0.09
//  GROUP   
//  ATOM CAD  CT2    -0.18
//  ATOM HAD1 HA      0.09
//  ATOM HAD2 HA      0.09
//  GROUP   
//  ATOM CBD  CT2    -0.28
//  ATOM HBD1 HA      0.09
//  ATOM HBD2 HA      0.09
//  ATOM CGD  CC      0.62
//  ATOM O1D  OC     -0.76
//  ATOM O2D  OC     -0.76
//  BOND FE  NA    FE  NB    FE  NC    FE  ND    NA  C1A   
//  BOND C1A C2A   C2A C3A   C3A C4A   NA  C4A   C2A CAA   
//  BOND CAA CBA   CBA CGA   CGA O1A   CGA O2A   C3A CMA   
//  BOND CHB C4A   CHB C1B   NB  C1B   C1B C2B   C2B C3B   
//  BOND C3B C4B   NB  C4B   C2B CMB   C3B CAB   CAB CBB   
//  BOND CHC C4B   CHC C1C   NC  C1C   C1C C2C   C2C C3C   
//  BOND C3C C4C   NC  C4C   C2C CMC   C3C CAC   CAC CBC   
//  BOND CHD C4C   CHD C1D   ND  C1D   C1D C2D   C2D C3D   
//  BOND C3D C4D   ND  C4D   C2D CMD   C3D CAD   CAD CBD   
//  BOND CBD CGD   CGD O1D   CGD O2D   CHA C4D   CHA C1A   
//  BOND CHA HA    CHB HB    CHC HC    CHD HD   
//  BOND CAA HAA1  CAA HAA2  CBA HBA1  CBA HBA2   
//  BOND CMA HMA1  CMA HMA2  CMA HMA3   
//  BOND CMB HMB1  CMB HMB2  CMB HMB3   
//  BOND CAB HAB   CBB HBB1  CBB HBB2   
//  BOND CMC HMC1  CMC HMC2  CMC HMC3   
//  BOND CAC HAC   CBC HBC1  CBC HBC2   
//  BOND CMD HMD1  CMD HMD2  CMD HMD3   
//  BOND CAD HAD1  CAD HAD2  CBD HBD1  CBD HBD2   
//  IMPR C2A C1A C3A CAA  C3A C2A C4A CMA  C2B C1B C3B CMB   
//  IMPR C3B C2B C4B CAB  C2C C1C C3C CMC  C3C C2C C4C CAC   
//  IMPR C2D C1D C3D CMD  C3D C2D C4D CAD  
//  IMPR CGA CBA O2A O1A  CGD CBD O2D O1D
//  IMPR C4A NA C1A C2A  C1A NA C4A C3A   
//  IMPR C4B NB C1B C2B  C1B NB C4B C3B   
//  IMPR C4C NC C1C C2C  C1C NC C4C C3C   
//  IMPR C4D ND C1D C2D  C1D ND C4D C3D   
//  IMPR NA C1A C2A C3A  NA C4A C3A C2A   
//  IMPR NB C1B C2B C3B  NB C4B C3B C2B   
//  IMPR NC C1C C2C C3C  NC C4C C3C C2C   
//  IMPR ND C1D C2D C3D  ND C4D C3D C2D   
//  IMPR NA C1A CHA C4D  NA C4A CHB C1B   
//  IMPR NB C1B CHB C4A  NB C4B CHC C1C   
//  IMPR NC C1C CHC C4B  NC C4C CHD C1D   
//  IMPR ND C1D CHD C4C  ND C4D CHA C1A   
//  IMPR CHA C1A C4D HA   
//  IMPR CHB C1B C4A HB   
//  IMPR CHC C1C C4B HC   
//  IMPR CHD C1D C4C HD   
//  IMPR C1A C2A CHA NA  C4A C3A CHB NA   
//  IMPR C1B C2B CHB NB  C4B C3B CHC NB   
//  IMPR C1C C2C CHC NC  C4C C3C CHD NC   
//  IMPR C1D C2D CHD ND  C4D C3D CHA ND   
//  IMPR NA C1A C4A FE   
//  IMPR NB C1B C4B FE   
//  IMPR NC C1C C4C FE   
//  IMPR ND C1D C4D FE   
//  IMPR CAB CBB C3B HAB  HAB CAB CBB HBB2  CAB CBB HBB2 HBB1   
//  IMPR CAC CBC C3C HAC  HAC CAC CBC HBC2  CAC CBC HBC2 HBC1   
//  ACCEPTOR NA   
//  ACCEPTOR O1A    ! CGA
//  ACCEPTOR O2A    ! CGA
//  ACCEPTOR NB   
//  ACCEPTOR NC   
//  ACCEPTOR ND   
//  ACCEPTOR O1D    ! CGD
//  ACCEPTOR O2D    ! CGD
//  IC FE   NA   C4A  C3A   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C3A  C4A  NA   C1A   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   NA   C1A  C2A   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4A  NA   FE   NB    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NA   FE   NB   C1B   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   NB   C1B  C2B   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2B  C1B  NB   C4B   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   NB   C4B  C3B   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4B  NB   FE   NC    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NB   FE   NC   C1C   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   NC   C1C  C2C   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2C  C1C  NC   C4C   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   NC   C4C  C3C   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4C  NC   FE   ND    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NC   FE   ND   C1D   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   ND   C1D  C2D   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2D  C1D  ND   C4D   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC FE   ND   C4D  C3D   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4A  NA   FE   CHB   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NA   FE   CHB  HB    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C4B  NB   FE   CHC   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NB   FE   CHC  HC    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C4C  NC   FE   CHD   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC NC   FE   CHD  HD    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C4D  ND   FE   CHA   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC ND   FE   CHA  HA    0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C3B  C1B  *C2B CMB   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4B  C2B  *C3B CAB   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2B  C3B  CAB  CBB   0.0000  0.0000  -45.0000  0.0000  0.0000 ! PREVENTS VINYL COLLISION
//  IC CHC  C1C  C2C  CMC   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C4C  C2C  *C3C CAC   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2C  C3C  CAC  CBC   0.0000  0.0000  -45.0000  0.0000  0.0000 ! PREVENTS VINYL COLLISION
//  IC C4D  C2D  *C3D CAD   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C3D  C1D  *C2D CMD   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2D  C3D  CAD  CBD   0.0000  0.0000 -120.0000  0.0000  0.0000
//  IC C3D  CAD  CBD  CGD   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CAD  CBD  CGD  O1D   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC CAD  CBD  CGD  O2D   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C4A  C2A  *C3A CMA   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C3A  C1A  *C2A CAA   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C1A  C2A  CAA  CBA   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC C2A  CAA  CBA  CGA   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CAA  CBA  CGA  O1A   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC CAA  CBA  CGA  O2A   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C3C  C1C  *C2C CMC   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CBA  O1A  *CGA O2A   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CBD  O1D  *CGD O2D   0.0000  0.0000  180.0000  0.0000  0.0000
//  PATCHING FIRS NONE LAST NONE   
//  
//  PRES NTER         1.00 ! standard N-terminus
//  GROUP                  ! use in generate statement
//  ATOM N    NH3    -0.30 !
//  ATOM HT1  HC      0.33 !         HT1	
//  ATOM HT2  HC      0.33 !     (+)/
//  ATOM HT3  HC      0.33 ! --CA--N--HT2
//  ATOM CA   CT1     0.21 !   |    \
//  ATOM HA   HB      0.10 !   HA    HT3
//  DELETE ATOM HN   
//  BOND HT1 N HT2 N HT3 N   
//  DONOR HT1 N   
//  DONOR HT2 N   
//  DONOR HT3 N   
//  IC HT1  N    CA   C     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC HT2  CA   *N   HT1   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC HT3  CA   *N   HT2   0.0000  0.0000  120.0000  0.0000  0.0000
//  
//  PRES GLYP         1.00 ! Glycine N-terminus
//  GROUP                  ! use in generate statement
//  ATOM N    NH3    -0.30 !
//  ATOM HT1  HC      0.33 !   HA1   HT1
//  ATOM HT2  HC      0.33 !   | (+)/
//  ATOM HT3  HC      0.33 ! --CA--N--HT2
//  ATOM CA   CT2     0.13 !   |    \
//  ATOM HA1  HB      0.09 !   HA2   HT3
//  ATOM HA2  HB      0.09 !
//  DELETE ATOM HN   
//  BOND HT1 N HT2 N HT3 N   
//  DONOR HT1 N   
//  DONOR HT2 N   
//  DONOR HT3 N   
//  IC HT1  N    CA   C     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC HT2  CA   *N   HT1   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC HT3  CA   *N   HT2   0.0000  0.0000  120.0000  0.0000  0.0000
//  
//  PRES PROP         1.00 ! Proline N-Terminal
//  GROUP                  ! use in generate statement
//  ATOM N    NP     -0.07 !   HA
//  ATOM HN1  HC      0.24 !   |
//  ATOM HN2  HC      0.24 !  -CA   HN1
//  ATOM CD   CP3     0.16 !  /  \ /
//  ATOM HD1  HA      0.09 !       N(+)
//  ATOM HD2  HA      0.09 !      / \
//  ATOM CA   CP1     0.16 !  -CD    HN2
//  ATOM HA   HB      0.09 !   | \
//  BOND HN1 N HN2 N       !  HD1 HD2
//  DONOR HN1 N   
//  DONOR HN2 N   
//  IC HN1  CA   *N   CD    0.0000  0.0000  120.0000  0.0000  0.0000
//  IC HN2  CA   *N   HN1   0.0000  0.0000  120.0000  0.0000  0.0000
//  
//  PRES ACE          0.00 ! acetylated N-terminus
//  GROUP                  ! use in generate statement
//  ATOM CAY  CT3    -0.27 !
//  ATOM HY1  HA      0.09 ! HY1 HY2 HY3
//  ATOM HY2  HA      0.09 !    \ | /
//  ATOM HY3  HA      0.09 !     CAY
//  GROUP                  !      |
//  ATOM CY   C       0.51 !      CY=OY
//  ATOM OY   O      -0.51 !      |
//                         !
//  BOND CY CAY CY N CAY HY1 CAY HY2 CAY HY3
//  DOUBLE OY CY  
//  IMPR CY CAY N OY    
//  IMPR N CY CA HN    
//  ACCEPTOR OY CY   
//  IC CY   N    CA   C     0.0000  0.0000  -60.0000  0.0000  0.0000
//  IC CY   CA   *N   HN    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CAY  CY   N    CA    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC N    CAY  *CY  OY    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OY   CY   CAY  HY1   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OY   CY   CAY  HY2   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OY   CY   CAY  HY3   0.0000  0.0000  -60.0000  0.0000  0.0000
//  
//  PRES ACP          0.00 ! acetylated N-terminus for proline
//  GROUP                  ! use in generate statement
//  ATOM CAY  CT3    -0.27 !
//  ATOM HY1  HA      0.09 ! HY1 HY2 HY3
//  ATOM HY2  HA      0.09 !    \ | /
//  ATOM HY3  HA      0.09 !     CAY
//  GROUP                  !      |
//  ATOM CY   C       0.51 !      CY=OY
//  ATOM OY   O      -0.51 !      |
//                         !
//  BOND CY CAY CY N CAY HY1 CAY HY2 CAY HY3
//  DOUBLE OY CY
//  IMPR CY CAY N OY
//  IMPR N CY CA CD 
//  ACCEPTOR OY CY  
//  IC CY   N    CA   C     0.0000  0.0000  -60.0000  0.0000  0.0000
//  IC CY   CA   *N   CD    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CAY  CY   N    CA    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC N    CAY  *CY  OY    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OY   CY   CAY  HY1   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OY   CY   CAY  HY2   0.0000  0.0000   60.0000  0.0000  0.0000 
//  IC OY   CY   CAY  HY3   0.0000  0.0000  -60.0000  0.0000  0.0000
//  
//  PRES CTER        -1.00 ! standard C-terminus
//  GROUP                  ! use in generate statement
//  ATOM C    CC      0.34 !   OT2(-)
//  ATOM OT1  OC     -0.67 !  /
//  ATOM OT2  OC     -0.67 ! -C
//  DELETE ATOM O          !  \\
//  BOND C OT2             !   OT1
//  DOUBLE  C OT1
//  !IMPR OT1 CA OT2 C
//  IMPR C CA OT2 OT1
//  ACCEPTOR OT1 C   
//  ACCEPTOR OT2 C   
//  IC N    CA   C    OT2   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OT2  CA   *C   OT1   0.0000  0.0000  180.0000  0.0000  0.0000
//  
//  PRES CT1          0.00 ! methylated C-terminus from methyl acetate
//  GROUP                  ! use in generate statement
//  ATOM N    NH1    -0.47 !
//  ATOM HN   H       0.31 !          OT1
//  ATOM CA   CT1     0.17 !     |   //
//  ATOM HA   HB      0.09 ! -N--CA--C       HT1
//  ATOM C    CD      0.63 !  |  |    \      /
//  ATOM OT1  OB     -0.52 ! HN  HA    OT2--CT--HT2
//  ATOM OT2  OS     -0.34 !                 \
//  ATOM CT   CT3    -0.14 !                 HT3
//  ATOM HT1  HA      0.09 !
//  ATOM HT2  HA      0.09 !
//  ATOM HT3  HA      0.09 !
//  DELETE ATOM O   
//  BOND  C  OT2  OT2 CT   
//  BOND CT HT1  CT HT2  CT  HT3
//  DOUBLE C  OT1    
//  IMPR C CA OT2 OT1
//  ACCEPTOR OT1 C   
//  ACCEPTOR OT2 C   
//  IC N    CA   C    OT2   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OT2  CA   *C   OT1   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CA   C    OT2  CT    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C    OT2  CT   HT1   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C    OT2  CT   HT2   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC C    OT2  CT   HT3   0.0000  0.0000  240.0000  0.0000  0.0000
//  
//  PRES CT2          0.00 ! amidated C-terminus
//  GROUP                  ! use in generate statement
//  ATOM C    CC      0.55 !        
//  ATOM O    O      -0.55 !     |
//  GROUP                  !   O=C
//  ATOM NT   NH2    -0.62 !     |
//  ATOM HT1  H       0.32 !     NT
//  ATOM HT2  H       0.30 !    / \
//  BOND C NT              !  HT1 HT2
//  BOND NT HT1 NT HT2     !
//  DIHE CA C NT HT2       !  (HT1 is cis to O)
//  IMPR C NT CA O C CA NT O   
//  IMPR NT C HT1 HT2 NT C HT2 HT1   
//  DONOR HT1 NT   
//  DONOR HT2 NT   
//  IC N    CA   C    O     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC NT   CA   *C   O     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CA   C    NT   HT1   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC HT1  C    *NT  HT2   0.0000  0.0000  180.0000  0.0000  0.0000
//  
//  PRES CT3          0.00 ! N-Methylamide C-terminus
//  GROUP                  ! use in generate statement
//  ATOM C    C       0.51 !
//  ATOM O    O      -0.51 !      |
//  GROUP                  !      C=O
//  ATOM NT   NH1    -0.47 !      | 
//  ATOM HNT  H       0.31 !      NT-HNT
//  ATOM CAT  CT3    -0.11 !      |
//  ATOM HT1  HA      0.09 ! HT1-CAT-HT3
//  ATOM HT2  HA      0.09 !      | 
//  ATOM HT3  HA      0.09 !     HT2
//                         !
//  BOND C NT  NT HNT  NT CAT  CAT HT1  CAT HT2  CAT HT3   
//  DIHE CA C NT CAT   
//  IMPR NT C CAT HNT C CA NT O   
//  DONOR HNT NT   
//  IC N    CA   C    O     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC NT   CA   *C   O     0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C    CAT  *NT  HNT   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC CA   C    NT   CAT   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C    NT   CAT  HT1   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC C    NT   CAT  HT2   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C    NT   CAT  HT3   0.0000  0.0000  -60.0000  0.0000  0.0000
//  
//  PRES ASPP         0.00 ! patch for protonated aspartic acid, proton on od2
//  GROUP                  ! via acetic acid, use in a patch statement
//  ATOM CB   CT2    -0.21 !
//  ATOM HB1  HA      0.09 ! HB1    OD1
//  ATOM HB2  HA      0.09 !  |    //
//  ATOM CG   CD      0.75 ! -CB--CG
//  ATOM OD1  OB     -0.55 !  |     \
//  ATOM OD2  OH1    -0.61 ! HB2     OD2-HD2
//  ATOM HD2  H       0.44 !
//  BOND OD2 HD2   
//  ANGLE HD2 OD2 CG   
//  DIHE HD2 OD2 CG OD1  HD2 OD2 CG CB   
//  DONOR HD2 OD2   
//  IC HD2  OD2  CG   OD1   0.0000  0.0000  0.0000  0.0000  0.0000
//  
//  PRES GLUP         0.00 ! patch for protonated glutamic acid, proton on oe2
//  GROUP                  ! via acetic acid, use in a patch statement
//  ATOM CG   CT2    -0.21 !
//  ATOM HG1  HA      0.09 ! HG1    OE1
//  ATOM HG2  HA      0.09 !  |    //
//  ATOM CD   CD      0.75 ! -CG--CD
//  ATOM OE1  OB     -0.55 !  |     \
//  ATOM OE2  OH1    -0.61 ! HG2     OE2-HE2
//  ATOM HE2  H       0.44 !
//  BOND OE2 HE2   
//  ANGLE HE2 OE2 CD   
//  DIHE HE2 OE2 CD OE1  HE2 OE2 CD CG   
//  DONOR HE2 OE2   
//  IC HE2  OE2  CD   OE1   0.0000  0.0000  0.0000  0.0000  0.0000
//  
//  PRES LINK         0.00 ! linkage for IMAGES or for joining segments
//                         ! 1 refers to previous (N terminal)
//                         ! 2 refers to next (C terminal)
//                         ! use in a patch statement
//  BOND 1C 2N   
//  ANGLE 1C 2N 2CA  1CA 1C 2N   
//  ANGLE 1O 1C 2N   1C  2N 2HN   
//  DIHE 1C  2N  2CA 2C   1C  2N  2CA 2HA  1C  2N  2CA 2CB   
//  DIHE 1HA 1CA 1C  2N   1N  1CA 1C  2N   1CB 1CA 1C  2N   
//  DIHE 1CA 1C  2N  2HN  1CA 1C  2N  2CA   
//  DIHE 1O  1C  2N  2HN  1O  1C  2N  2CA   
//  IMPR 2N 1C 2CA 2HN  1C 1CA 2N 1O   
//  IC 1N   1CA  1C   2N    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC 2N   1CA  *1C  1O    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC 1CA  1C   2N   2CA   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC 1C   2N   2CA  2C    0.0000  0.0000  180.0000  0.0000  0.0000
//  IC 1C   2CA  *2N  2HN   0.0000  0.0000  180.0000  0.0000  0.0000
//  
//  PRES DISU        -0.36 ! patch for disulfides. Patch must be 1-CYS and 2-CYS.
//  GROUP                  ! use in a patch statement
//  ATOM 1CB  CT2    -0.10 !
//  ATOM 1SG  SM     -0.08 !           2SG--2CB--
//  GROUP                  !          /
//  ATOM 2SG  SM     -0.08 ! -1CB--1SG
//  ATOM 2CB  CT2    -0.10 !
//  DELETE ATOM 1HG1   
//  DELETE ATOM 2HG1   
//  BOND 1SG 2SG   
//  ANGLE 1CB 1SG 2SG 1SG 2SG 2CB   
//  DIHE 1HB1 1CB 1SG 2SG 1HB2 1CB 1SG 2SG   
//  DIHE 2HB1 2CB 2SG 1SG 2HB2 2CB 2SG 1SG   
//  DIHE 1CA 1CB 1SG 2SG 1SG 2SG 2CB 2CA   
//  DIHE 1CB 1SG 2SG 2CB   
//  !DIHE 1CB 1SG 2SG 2CB   
//  IC 1CA  1CB  1SG  2SG   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC 1CB  1SG  2SG  2CB   0.0000  0.0000   90.0000  0.0000  0.0000
//  IC 1SG  2SG  2CB  2CA   0.0000  0.0000  180.0000  0.0000  0.0000
//  
//  PRES HS2          0.00 ! Patch for neutral His, move proton from ND1 to NE2
//  GROUP                  ! use in a patch statement
//  ATOM CE1  CPH2    0.25 !                 HE1
//  ATOM HE1  HR1     0.13 !                 /
//  ATOM ND1  NR2    -0.70 !   HB1    ND1--CE1
//  ATOM CG   CPH1    0.22 !   |     /      |
//  ATOM CB   CT2    -0.08 !  -CB--CG       |
//  ATOM HB1  HA      0.09 !   |     \      |
//  ATOM HB2  HA      0.09 !   HB2    CD2--NE2
//  GROUP                  !           |     \
//  ATOM NE2  NR1    -0.36 !          HD2    HE2
//  ATOM HE2  H       0.32
//  ATOM CD2  CPH1   -0.05
//  ATOM HD2  HR3     0.09
//  DELETE ATOM HD1   
//  DELETE ACCE NE2   
//  BOND NE2 HE2   
//  ANGLE CD2 NE2 HE2  CE1 NE2 HE2   
//  DIHE HE2 NE2 CE1 HE1  HE2 NE2 CE1 ND1  HE2 NE2 CD2 HD2   
//  DIHE HE2 NE2 CD2 CG   
//  IMPR NE2 CD2 CE1 HE2  NE2 CE1 CD2 HE2   
//  DONOR HE2 NE2   
//  ACCEPTOR ND1   
//  IC CE1  CD2  *NE2 HE2   0.0000  0.0000  180.0000  0.0000  0.0000
//  
//  RESI O2           0.00 ! O2 ligand for heme
//  GROUP                
//  ATOM O1   OM      0.021
//  ATOM O2   OM     -0.021
//  BOND O1 O2   
//  PATCHING FIRS NONE LAST NONE   
//  
//  RESI CO           0.00 ! CO ligand for heme
//  GROUP   
//  ATOM C    CM      0.021
//  ATOM O    OM     -0.021
//  TRIPLE C O   
//  PATCHING FIRS NONE LAST NONE   
//  
//  PRES FHEM         0.00 ! FIX UP THE HEME BY DELETING UNWANTED AUTOGENERATED ANGLES
//                         ! unliganded heme patch
//  DELETE ANGLE 1NA 1FE 1NC  1NB 1FE 1ND   
//  
//  PRES PHEM         0.00 ! Patch for HEME to His link.
//                         ! Patch residues must be 1-HIS, and 2-HEME.
//  DELETE ANGLE 2NA 2FE 2NC  2NB 2FE 2ND 
//  BOND 1NE2 2FE   
//  ANGLE 1CD2 1NE2 2FE  1CE1 1NE2 2FE  1NE2 2FE 2NA  1NE2 2FE 2NB   
//  ANGLE 1NE2 2FE  2NC  1NE2 2FE  2ND   
//  IC 1CD2 1NE2 2FE  2NA   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1CD2 1NE2 2FE  2NB   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1CD2 1NE2 2FE  2NB   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1CD2 1NE2 2FE  2NB   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1CE1 1NE2 2FE  2NA   0.0000  0.0000    0.0000  0.0000  0.0000
//  
//  PRES PLO2         0.00 ! Patch residue for Heme ligand.  Residues must be
//                         ! 1-O2 , 2-HEME , and 3-HIS
//                         ! O1 of the oxygen is bonded to the iron.
//  BOND 1O1 2FE        
//  ANGLE 1O2 1O1 2FE  1O1 2FE 2NA  1O1 2FE 2NB 
//  ANGLE 1O1 2FE 2NC  1O1 2FE 2ND   
//  DIHE 1O2 1O1 2FE 2NA   
//  IC 1O2  1O1  2FE  2NA   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1O2  1O1  2FE  3NE2  0.0000  0.0000    0.0000  0.0000  0.0000
//  
//  PRES PLIG         0.00 ! Patch residue for Heme ligand. Residues must be,
//                         ! 1-CO , 2-HEME , and 3-HIS
//  BOND 1C 2FE          
//  ANGLE 1C 2FE 3NE2    
//  ANGLE 1O 1C  2FE  1C 2FE 2NA  1C 2FE 2NB   
//  ANGLE 1C 2FE 2NC  1C 2FE 2ND   
//  IC 1O   1C   2FE  2NA   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC 1O   1C   2FE  3NE2  0.0000  0.0000    0.0000  0.0000  0.0000
//  
//  ! patches for cyclic peptides
//  PRES LIG1     0.00000 ! linkage for cyclic peptide
//                  !       1 refers to the C terminus which is a glycine
//                  !       2 refers to the N terminus 
//                  !       use in a patch statement, perform initial
//                  !       generation using first NONE last NONE
//  BOND 1C 2N
//  ANGLE 1C 2N 2CA 1CA 1C 2N
//  ANGLE 1O 1C 2N 1C 2N 2HN
//  DIHE 1C 2N 2CA 2C 1C 2N 2CA 2HA 1C 2N 2CA 2CB
//  DIHE 1HA1 1CA 1C 2N 1N 1CA 1C 2N 1HA2 1CA 1C 2N
//  DIHE 1CA 1C 2N 2HN 1CA 1C 2N 2CA
//  DIHE 1O 1C 2N 2HN 1O 1C 2N 2CA
//  DIHE 1CA 1C 2N 2CA
//  IMPR 2N 1C 2CA 2HN 1C 1CA 2N 1O
//  IC 1N   1CA  1C   2N    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 2N   1CA  *1C  1O    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1CA  1C   2N   2CA   0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2N   2CA  2C    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2CA  *2N  2HN   0.0000  0.0000 180.0000  0.0000  0.0000
//  
//  PRES LIG2     0.00000 ! linkage for cyclic peptide
//                  !       1 refers to the C terminus
//                  !       2 refers to the N terminus which is a glycine
//                  !       use in a patch statement, perform initial
//                  !       generation using first NONE last NONE
//  BOND 1C 2N
//  ANGLE 1C 2N 2CA 1CA 1C 2N
//  ANGLE 1O 1C 2N 1C 2N 2HN
//  DIHE 1C 2N 2CA 2C 1C 2N 2CA 2HA1 1C 2N 2CA 2HA2
//  DIHE 1HA 1CA 1C 2N 1N 1CA 1C 2N 1CB 1CA 1C 2N
//  DIHE 1CA 1C 2N 2HN 1CA 1C 2N 2CA
//  DIHE 1O 1C 2N 2HN 1O 1C 2N 2CA
//  DIHE 1CA 1C 2N 2CA
//  IMPR 2N 1C 2CA 2HN 1C 1CA 2N 1O
//  IC 1N   1CA  1C   2N    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 2N   1CA  *1C  1O    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1CA  1C   2N   2CA   0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2N   2CA  2C    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2CA  *2N  2HN   0.0000  0.0000 180.0000  0.0000  0.0000
//  
//  PRES LIG3     0.00000 ! linkage for cyclic peptide
//                  !       1 refers to the C terminus which is a glycine
//                  !       2 refers to the N terminus which is a glycine
//                  !       use in a patch statement, perform initial
//                  !       generation using first NONE last NONE
//  BOND 1C 2N
//  ANGLE 1C 2N 2CA 1CA 1C 2N
//  ANGLE 1O 1C 2N 1C 2N 2HN
//  DIHE 1C 2N 2CA 2C 1C 2N 2CA 2HA1 1C 2N 2CA 2HA2
//  DIHE 1HA1 1CA 1C 2N 1N 1CA 1C 2N 1HA2 1CA 1C 2N
//  DIHE 1CA 1C 2N 2HN 1CA 1C 2N 2CA
//  DIHE 1O 1C 2N 2HN 1O 1C 2N 2CA
//  DIHE 1CA 1C 2N 2CA
//  IMPR 2N 1C 2CA 2HN 1C 1CA 2N 1O
//  IC 1N   1CA  1C   2N    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 2N   1CA  *1C  1O    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1CA  1C   2N   2CA   0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2N   2CA  2C    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC 1C   2CA  *2N  2HN   0.0000  0.0000 180.0000  0.0000  0.0000
//  
//  RESI DUM       0.00 ! DUMMY ATOM
//  GROUP
//  ATOM DUM DUM   0.00
//  PATCHING FIRST NONE LAST NONE
//  
//  !END
//  !phosphotyrosine information deleted
//  !
//  
//  !lipids section
//  RESI MAS          0.00 ! methylacetate
//  GROUP                  !
//  ATOM C1   CTL3   -0.17 !           H22
//  ATOM C    CL      0.63 !           |
//  ATOM OM   OSL    -0.34 !       H21-C2-H23
//  ATOM C2   CTL3   -0.14 !             \
//  ATOM O    OBL    -0.52 !             OM
//  ATOM H11  HAL3    0.09 !            /
//  ATOM H12  HAL3    0.09 !         O=C
//  ATOM H13  HAL3    0.09 !           |
//  ATOM H21  HAL3    0.09 !       H11-C1-H13
//  ATOM H22  HAL3    0.09 !           |
//  ATOM H23  HAL3    0.09 !           H12
//   
//  BOND C1   C       C    OM      OM    C2
//  DOUBLE C    O
//  BOND C1   H11     C1   H12     C1   H13
//  BOND C2   H21     C2   H22     C2   H23
//  IMPR C OM C1 O
//  ! internal coordinates from experiment for heavy atoms
//  IC C1   C    OM   C2   1.520     109.0     180.0     114.8     1.437
//  IC O    C    OM   C2   1.200     125.9       0.0     114.8     1.437
//  IC H11  C1   C    OM   1.1       108.9     180.0     109.0     1.334
//  IC H12  C1   C    OM   1.1       109.75     60.4     109.0     1.334
//  IC H13  C1   C    OM   1.1       109.75    -60.4     109.0     1.334
//  IC H21  C2   OM   C    1.0788    109.94    180.0     114.8     1.334
//  IC H22  C2   OM   C    1.0802    110.50     60.5     114.8     1.334
//  IC H23  C2   OM   C    1.0802    110.50    -60.5     114.8     1.334
//  
//  RESI ETAC         0.00 ! Ethylacetate
//                         !            H213
//  GROUP                  !             |
//  ATOM C1   CTL3   -0.17 !        H211-C21-H212
//  ATOM C    CL      0.63 !             /
//  ATOM OM   OSL    -0.34 !        H22-C2-H23
//  ATOM C2   CTL2   -0.05 !             \
//  ATOM O    OBL    -0.52 !             OM
//  ATOM H11  HAL3    0.09 !            /
//  ATOM H12  HAL3    0.09 !         O=C
//  ATOM H13  HAL3    0.09 !            \
//  ATOM H22  HAL2    0.09 !         H11-C1-H13
//  ATOM H23  HAL2    0.09 !             |
//  GROUP                  !             H12
//  ATOM C21  CTL3   -0.27 
//  ATOM H211 HAL3    0.09
//  ATOM H212 HAL3    0.09
//  ATOM H213 HAL3    0.09
//  BOND C1   C       C    OM      OM    C2
//  DOUBLE C    O
//  BOND C1   H11     C1   H12     C1   H13
//  BOND C2   C21     C2   H22     C2   H23
//  BOND C21  H211    C21  H212    C21  H213
//  IMPR C OM C1 O 
//  ! internal coordinates from experiment for heavy atoms
//  IC C1   C    OM   C2   1.520     109.0     180.0     114.8     1.437
//  IC O    C    OM   C2   1.200     125.9       0.0     114.8     1.437
//  IC H11  C1   C    OM   1.1       108.9     180.0     109.0     1.334
//  IC H12  C1   C    OM   1.1       109.75     60.4     109.0     1.334
//  IC H13  C1   C    OM   1.1       109.75    -60.4     109.0     1.334
//  IC C21  C2   OM   C    1.520     109.94    180.0     114.8     1.334
//  IC H22  C2   OM   C    1.0802    110.50     60.5     114.8     1.334
//  IC H23  C2   OM   C    1.0802    110.50    -60.5     114.8     1.334
//  IC H211 C21  C2   OM   1.1       108.90    180.0     116.7     1.437
//  IC H212 C21  C2   OM   1.1       108.90     60.0     116.7     1.437
//  IC H213 C21  C2   OM   1.1       108.90    -60.0     116.7     1.437
//  
//  RESI MPRO         0.00 ! Methylpropionate
//  GROUP                  !
//  ATOM C1   CTL2   -0.08 !           H22
//  ATOM C    CL      0.63 !           |
//  ATOM OM   OSL    -0.34 !       H21-C2-H23
//  ATOM C2   CTL3   -0.14 !             \
//  ATOM O    OBL    -0.52 !             OM
//  ATOM H12  HAL2    0.09 !            /
//  ATOM H13  HAL2    0.09 !         O=C
//  ATOM H21  HAL3    0.09 !            \
//  ATOM H22  HAL3    0.09 !         H12-C1-H13
//  ATOM H23  HAL3    0.09 !            /
//  GROUP                  !     H112-C11-H111
//  ATOM C11  CTL3   -0.27 !           |
//  ATOM H111 HAL3    0.09 !          H113
//  ATOM H112 HAL3    0.09 !
//  ATOM H113 HAL3    0.09 ! 
//  BOND C1   C       C    OM      C    O      OM    C2
//  BOND C1   C11     C1   H12     C1   H13
//  BOND C11  H111    C11  H112    C11  H113
//  BOND C2   H21     C2   H22     C2   H23
//  IMPR C OM C1 O
//  ! internal coordinates from experiment for heavy atoms
//  IC C1   C    OM   C2   1.520     109.0     180.0     114.8     1.437
//  IC O    C    OM   C2   1.200     125.9       0.0     114.8     1.437
//  IC C11  C1   C    OM   1.520     108.9     180.0     109.0     1.334
//  IC H12  C1   C    OM   1.1       109.75     60.4     109.0     1.334
//  IC H13  C1   C    OM   1.1       109.75    -60.4     109.0     1.334
//  IC H21  C2   OM   C    1.0788    109.94    180.0     114.8     1.334
//  IC H22  C2   OM   C    1.0802    110.50     60.5     114.8     1.334
//  IC H23  C2   OM   C    1.0802    110.50    -60.5     114.8     1.334
//  IC H111 C11  C1   C    1.1       109.75    180.0     109.0     1.520
//  IC H112 C11  C1   C    1.1       109.75     60.4     109.0     1.520
//  IC H113 C11  C1   C    1.1       109.75    -60.4     109.0     1.520
//   
//  RESI ACEH         0.00 ! acetic acid
//                         ! atoms in proper order for molvib input
//  GROUP                  !
//  ATOM C2   CTL3   -0.30 !
//  ATOM C1   CL      0.75 !   H21      O2
//  ATOM H21  HAL3    0.09 !      \    //
//  ATOM H22  HAL3    0.09 !  H22-C2--C1
//  ATOM H23  HAL3    0.09 !      /     \
//  ATOM O2   OBL    -0.55 !   H23       O1-HO1
//  ATOM O1   OHL    -0.61 !
//  ATOM HO1  HOL     0.44 !
//  BOND C1 O1  O1 HO1  C1 C2  C2 H21  C2 H22  C2 H23
//  DOUBLE C1 O2
//  IMPR C1 O1 C2 O2
//  IC O2   C1   C2   H21   0.0000  0.0000   0.0000  0.0000  0.0000
//  IC HO1  O1   C1   O2    0.0000  0.0000   0.0000  0.0000  0.0000
//  IC HO1  O1   C1   C2    0.0000  0.0000 180.0000  0.0000  0.0000
//  IC O1   C1   C2   H21   0.0000  0.0000 180.0000  0.0000  0.0000
//  IC O1   C1   C2   H22   0.0000  0.0000  60.0000  0.0000  0.0000
//  IC O1   C1   C2   H23   0.0000  0.0000 -60.0000  0.0000  0.0000
//  
//  RESI DMPA        -1.00 ! Dimethylphosphate
//  GROUP                  !
//  ATOM P1   PL      1.50 !
//  ATOM O3   O2L    -0.78 !
//  ATOM O4   O2L    -0.78 !           H11
//  ATOM O1   OSL    -0.57 !            |
//  ATOM O2   OSL    -0.57 !       H13- C1-H12
//                         !             \
//  ATOM C1   CTL3   -0.17 !     (-) O3   O1
//  ATOM H11  HAL3    0.09 !          \ /
//  ATOM H12  HAL3    0.09 !           P1 (+)
//  ATOM H13  HAL3    0.09 !          /  \
//                         !     (-) O4   O2
//  ATOM C2   CTL3   -0.17 !             /
//  ATOM H21  HAL3    0.09 !        H23-C2-H22
//  ATOM H22  HAL3    0.09 !            |
//  ATOM H23  HAL3    0.09 !           H21
//                         !
//  BOND P1   O1     P1   O2    P1   O3    P1   O4    O1   C1    O2   C2
//  BOND C1   H11    C1   H12   C1   H13   C2   H21   C2   H22   C2   H23
//  
//  ! IC FOR THE g,g conformation (3-21G* opt. structure)
//  IC O3   P1   O1   C1   1.4723    107.31    000.0     117.79    1.4356
//  IC O4   P1   O2   C2   1.4722    000.0     000.0     117.79    1.4357
//  IC O1   P1   O2   C2   1.6343    000.0      73.8     117.79    1.4357
//  IC O2   P1   O1   C1   1.6344    000.0      73.7     117.79    1.4356
//  IC H11  C1   O1   P1   1.0827    107.8     174.8     117.79    1.6343
//  IC H12  C1   O1   P1   1.0800    110.4      54.1     117.79    1.6343
//  IC H13  C1   O1   P1   1.0848    110.7     294.3     117.79    1.6343
//  IC H21  C2   O2   P1   1.0827    107.9     174.7     117.79    1.6344
//  IC H22  C2   O2   P1   1.0800    110.4      54.1     117.79    1.6344
//  IC H23  C2   O2   P1   1.0848    110.7     294.2     117.79    1.6344
//   
//  RESI MP_1        -1.00 ! Methylphosphate, anionic
//  GROUP                  !
//  ! atom order for molvib
//  ATOM C1   CTL3   -0.17  !
//  ATOM O1   OSL    -0.62  !                 H11
//  ATOM P1   PL      1.50  !                  |
//  ATOM O2   OHL    -0.68  !            H13--C1--H12
//  ATOM O3   O2L    -0.82  !                  |
//  ATOM O4   O2L    -0.82  !                 O1
//  ATOM H11  HAL3    0.09  !                  |
//  ATOM H12  HAL3    0.09  !             O4==P1==O3 (-)
//  ATOM H13  HAL3    0.09  !                  |
//  ATOM H2   HOL     0.34  !                 O2
//                          !                   \
//                          !                    H2
//  
//  BOND P1   O1     P1   O2    P1   O3    P1   O4    O1   C1
//  BOND C1   H11    C1   H12   C1   H13   O2   H2
//  
//  IC O3   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC O4   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC O2   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC H11  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  IC H12  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  IC H13  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  IC H2   O2   P1   O1   0.0000    000.00    000.0     000.00    0.0000
//   
//  RESI MP_2        -2.00 ! Methylphosphate, dianionic
//  GROUP                  !
//  ATOM P1   PL      1.10 !
//  ATOM O1   OSL    -0.40 !                 H11
//  ATOM O2   O2L    -0.90 !                  |
//  ATOM O3   O2L    -0.90 !            H13--C1--H12
//  ATOM O4   O2L    -0.90 !                  |
//  GROUP                  !                  O1
//  ATOM C1   CTL3   -0.27 !                  |
//  ATOM H11  HAL3    0.09 !          (-) O4--P1(+)--O3 (-)
//  ATOM H12  HAL3    0.09 !                  |
//  ATOM H13  HAL3    0.09 !                  O2 (-)
//                         !
//  BOND P1   O1     P1   O2    P1   O3    P1   O4    O1   C1
//  BOND C1   H11    C1   H12   C1   H13
//  
//  IC O3   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC O4   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC O2   P1   O1   C1   0.0000    000.00    000.0     000.00    0.0000
//  IC H11  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  IC H12  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  IC H13  C1   O1   P1   0.0000    000.00    000.0     000.00    0.0000
//  ! dummy to analyze cetain angles
//  IC O3   P1   O4   O1   0.0         0.0       0.0       0.0     0.0
//   
//  RESI  MSO4       -1.00 ! Methylsulfate
//  GROUP                  !
//  ATOM S    SL      1.33 !           OS2(-1)
//  ATOM OS1  OSL    -0.28 !            |
//  ATOM OS2  O2L    -0.65 ! (-1) OS2--S(+2)--OS4 (-1)
//  ATOM OS3  O2L    -0.65 !            |
//  ATOM OS4  O2L    -0.65 !           OS1
//  ATOM C1   CTL3   -0.37 !             \
//  ATOM H11  HAL3    0.09 !         H11-C1-H13
//  ATOM H12  HAL3    0.09 !              |
//  ATOM H13  HAL3    0.09 !             H12
//                         !
//  BOND  S  OS1  S  OS2  S  OS3  S  OS4  OS1  C1
//  BOND  C1 H11  C1 H12  C1 H13
//  ACCE  OS1
//  ACCE  OS2
//  ACCE  OS3
//  ACCE  OS4
//  
//  IC OS4  S    OS2  OS1   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS2  S    OS2  OS3   0.0000  0.0000  -60.0000  0.0000  0.0000
//  IC OS3  S    OS1  OS4   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS1  S   OS3   OS2   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC C1   OS1   S   OS2   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC S    OS1  C1   OS3   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS1  S    OS4  OS2   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OS1  S    OS2  OS3   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OS1  S    OS3  OS2   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC OS4  S    OS2  OS1   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS4  S    OS3  OS1   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS3  S    OS2  OS1   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS4  S    OS1  C1    0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS2  S    OS1  C1    0.0000  0.0000   60.0000  0.0000  0.0000
//  IC OS3  S    OS1  C1    0.0000  0.0000   60.0000  0.0000  0.0000
//  
//  Resi BUTA        0.00  ! BUTANE
//  Group
//  Atom  h11 HAL3    0.09 !    H2
//  Atom  h12 HAL3    0.09 !     |
//  Atom  h13 HAL3    0.09 ! H1-C1-H3
//  Atom  c1  CTL3   -0.27 !     |
//  Group                  !     |
//  Atom  h21 HAL2    0.09 ! H4-C2-H5
//  Atom  h22 HAL2    0.09 !     |
//  Atom  c2  CTL2   -0.18 !     |
//  Group                  !     |
//  Atom  h31 HAL2    0.09 ! H6-C3-H7
//  Atom  h32 HAL2    0.09 !     |
//  atom  c3  CTL2   -0.18 !     |
//  Group                  !     |
//  atom  h41 HAL3    0.09 ! H8-C4-H10
//  atom  h42 HAL3    0.09 !     |
//  atom  h43 HAL3    0.09 !    H9
//  atom  c4  CTL3   -0.27 !
//  Bond h11 c1  h12 c1  h13 c1  c1 c2
//  Bond h21 c2  h22 c2  c2  c3
//  Bond h31 c3  h32 c3  c3  c4
//  Bond h41 c4  h42 c4  h43 c4
//  ic  c1  c2  c3  c4  0.00  0.00  180.0  0.00 0.00
//  ic  c2  c3  c4  h41 0.00  0.00  180.0  0.00 0.00
//  ic  c3  h41 *c4 h42 0.00  0.00  120.0  0.00 0.00
//  ic  c3  h41 *c4 h43 0.00  0.00 -120.0  0.00 0.00
//  ic  c3  c2  c1  h11 0.00  0.00  180.0  0.00 0.00
//  ic  c2  h11 *c1 h12 0.00  0.00  120.0  0.00 0.00
//  ic  c2  h11 *c1 h13 0.00  0.00 -120.0  0.00 0.00
//  ic  c1  c3  *c2 h21 0.00  0.00  120.0  0.00 0.00
//  ic  c1  c3  *c2 h22 0.00  0.00 -120.0  0.00 0.00
//  ic  c2  c4  *c3 h31 0.00  0.00  120.0  0.00 0.00
//  ic  c2  c4  *c3 h32 0.00  0.00 -120.0  0.00 0.00
//  
//  Resi HEXA         0.00 ! hexane
//  Group
//  Atom  h11 HAL3    0.09 !    H2
//  Atom  h12 HAL3    0.09 !     |
//  Atom  h13 HAL3    0.09 ! H1-C1-H3
//  Atom  c1  CTL3   -0.27 !     |
//  Group                  !     |
//  Atom  h21 HAL2    0.09 ! H4-C2-H5
//  Atom  h22 HAL2    0.09 !     |
//  Atom  c2  CTL2   -0.18 !     |
//  Group                  !     |
//  Atom  h31 HAL2    0.09 ! H6-C3-H7
//  Atom  h32 HAL2    0.09 !     |
//  atom  c3  CTL2   -0.18 !     |
//  Group                  !     |
//  atom  h41 HAL2    0.09 ! H8-C4-H10
//  atom  h42 HAL2    0.09 !     |
//  atom  c4  CTL2   -0.18 !     |
//  Group                  !     |
//  atom  h51 HAL2    0.09 ! H51-C5-H152
//  atom  h52 HAL2    0.09 !     |
//  atom  c5  CTL2   -0.18 !     |
//  Group                  !     |
//  atom  h61 HAL2    0.09 ! H61-C4-H62
//  atom  h62 HAL2    0.09 !     |
//  atom  h63 HAL2    0.09 !    H63
//  atom  c6  CTL2   -0.27 !
//  Bond h11 c1  h12 c1  h13 c1  c1 c2
//  Bond h21 c2  h22 c2  c2  c3
//  Bond h31 c3  h32 c3  c3  c4
//  Bond h41 c4  h42 c4  c4  c5
//  Bond h51 c5  h52 c5  c5  c6
//  Bond h61 c6  h62 c6  c6  h63
//  ic  c1  c2  c3  c4  0.00  0.00  180.0   0.00 0.00
//  ic  c2  c3  c4  c5  0.00  0.00  180.0   0.00 0.00
//  ic  c3  c4  c5  c6  0.00  0.00  180.0   0.00 0.00
//  ic  c3  c2  c1  h11 0.00  0.00  180.0   0.00 0.00
//  ic  h11 c2 *c1  h12 0.00  0.00  120.0   0.00 0.00
//  ic  h11 c2 *c1  h13 0.00  0.00  240.0   0.00 0.00
//  ic  c1  c3 *c2  h21 0.00  0.00  120.0   0.00 0.00
//  ic  c1  c3 *c2  h22 0.00  0.00  240.0   0.00 0.00
//  ic  c2  c4 *c3  h31 0.00  0.00  120.0   0.00 0.00
//  ic  c2  c4 *c3  h32 0.00  0.00  240.0   0.00 0.00
//  ic  c3  c5 *c4  h41 0.00  0.00  120.0   0.00 0.00
//  ic  c3  c5 *c4  h42 0.00  0.00  240.0   0.00 0.00
//  ic  c4  c6 *c5  h51 0.00  0.00  120.0   0.00 0.00
//  ic  c4  c6 *c5  h52 0.00  0.00  240.0   0.00 0.00
//  ic  c4  c5  c6  h61 0.00  0.00  180.0   0.00 0.00
//  ic  h61 c5 *c6  h62 0.00  0.00  120.0   0.00 0.00
//  ic  h61 c5 *c6  h63 0.00  0.00  240.0   0.00 0.00
//  
//  Resi ETHE       0.00 ! ethylene, yin/adm jr.
//  Group 
//   Atom c1  cel2 -0.42 !
//   Atom h11 hel2  0.21 !  H11     H21
//   Atom h12 hel2  0.21 !    \     /
//  Group                !     C1=C2
//   Atom c2  cel2 -0.42 !    /     \
//   Atom h21 hel2  0.21 !  H12     H22
//   Atom h22 hel2  0.21 !
//  Bond c1 h11  c1 h12
//  Double c1 c2
//  Bond c2 h21  c2 h22
//  IMPR c1 c2 h12 h11
//  IMPR c1 c2 h11 h12
//  IMPR c2 c1 h22 h21
//  IMPR c2 c1 h21 h22
//  ic h11 c1 c2  h21  0.00 0.00  180.0 0.0  0.0
//  ic h12 c2 *c1 h11  0.00 0.00  180.0 0.0  0.0
//  ic h22 c1 *c2 h21  0.00 0.00  180.0 0.0  0.0
//  ic c1  c2 h21 h22  0.00 0.00  180.0 0.0  0.0
//  patc firs none last none
//  
//  Resi PRPE       0.00 ! propene, yin/adm jr.
//  Group
//   Atom c1  cel2 -0.42 !
//   Atom h11 hel2  0.21 ! H11     H21
//   Atom h12 hel2  0.21 !   \     /
//  Group                !    C1=C2   H31
//   Atom c2  cel1 -0.15 !   /     \  /
//   Atom h21 HEL1  0.15 ! H12      C3
//  Group                !         /  \
//   Atom c3  ctl3 -0.27 !       H33  H32
//   Atom h31 HAL3  0.09 !
//   Atom h32 HAL3  0.09 !
//   Atom h33 HAL3  0.09 !
//  Bond c1 h11  c1 h12
//  Double c1 c2
//  Bond c2 h21
//  Bond c2 c3
//  bond c3 h31  c3 h32  c3 h33
//  ic h11 c1 c2  h21  0.00 0.00  180.0 0.0  0.0
//  ic h12 c2 *c1 h11  0.00 0.00  180.0 0.0  0.0
//  ic c3  c1 *c2 h21  0.00 0.00  180.0 0.0  0.0
//  ic h31 c3 c2  c1   0.00 0.00    0.0 0.0  0.0
//  ic h32 c3 c2  c1   0.00 0.00  120.0 0.0  0.0
//  ic h33 c3 c2  c1   0.00 0.00 -120.0 0.0  0.0
//  patc firs none last none
//  
//  Resi BTE1       0.00 ! 1-Butene, yin/adm jr.
//  Group        
//   Atom c1  cel2 -0.42 !
//   Atom h11 hel2  0.21 ! H11     H21 H41
//   Atom h12 hel2  0.21 !   \     /    |
//  Group                !    C1=C2    C4-H42
//   Atom c2  cel1 -0.15 !   /     \  /  \
//   Atom h21 HEL1  0.15 ! H12      C3    H43
//  Group                !         /  \
//   Atom c3  ctl2 -0.18 !       H31  H32
//   Atom h31 HAL2  0.09 !
//   Atom h32 HAL2  0.09 !
//  Group
//   Atom c4  ctl3 -0.27
//   Atom h41 HAL3  0.09
//   Atom h42 HAL3  0.09
//   Atom h43 HAL3  0.09
//  BOND c1 h11  c1 h12
//  Double c1 c2
//  BOND c2 h21
//  BOND c2 c3
//  BOND c3 h31  c3 h32
//  BOND c3 c4
//  BOND c4 h41  c4 h42  c4 h43
//  ic  c1   c2 c3  c4   0.00 0.00    0.0 0.00 0.00
//  ic  h11  c1 c2  c3   0.00 0.00  180.0 0.00 0.00
//  ic  h12  c1 c2  c3   0.00 0.00    0.0 0.00 0.00
//  ic  h21  c1 *c2 c3   0.00 0.00  180.0 0.00 0.00
//  ic  h31  c2 *c3 c4   0.00 0.00  120.0 0.00 0.00
//  ic  h32  c2 *c3 c4   0.00 0.00 -120.0 0.00 0.00
//  ic  h41  c4 c3  c2   0.00 0.00  180.0 0.00 0.00
//  ic  h42  c4 c3  c2   0.00 0.00   60.0 0.00 0.00
//  ic  h43  c4 c3  c2   0.00 0.00  -60.0 0.00 0.00
//  patc firs none last none
//  
//  
//  Resi BTE2       0.00 ! 2-Butene, yin/adm jr.
//  Group
//   Atom c1  ctl3 -0.27 !  H12 H13
//   Atom h11 HAL3  0.09 !    \ |
//   Atom h12 HAL3  0.09 ! H13-C1      H31
//   Atom h13 HAL3  0.09 !       \     /
//  Group                !        C2=C3
//   Atom c2  cel1 -0.15 !       /     \
//   Atom h21 HEL1  0.15 !     H21      C4-H41
//  Group                !              | \
//   Atom c3  cel1 -0.15 !            H43 H42
//   Atom h31 HEL1  0.15 !
//  Group
//   Atom c4  ctl3 -0.27
//   Atom h41 HAL3  0.09
//   Atom h42 HAL3  0.09
//   Atom h43 HAL3  0.09
//  BOND c1 h11  c1 h12  c1 h13
//  BOND c1 c2
//  BOND c2 h21
//  DOUBLE c2 c3
//  BOND c3 h31
//  BOND c3 c4
//  BOND c4 h41  c4 h42  c4 h43
//  ic  c1   c2 c3  c4   0.00 0.00  180.0 0.00 0.00
//  ic  h11  c1 c2  c3   0.00 0.00    0.0 0.00 0.00
//  ic  h12  c1 c2  c3   0.00 0.00  120.0 0.00 0.00
//  ic  h13  c1 c2  c3   0.00 0.00 -120.0 0.00 0.00
//  ic  h21  c1 *c2 c3   0.00 0.00  180.0 0.00 0.00
//  ic  h31  c4 *c3 c2   0.00 0.00  120.0 0.00 0.00
//  ic  h41  c4 c3  c2   0.00 0.00    0.0 0.00 0.00
//  ic  h42  c4 c3  c2   0.00 0.00  120.0 0.00 0.00
//  ic  h43  c4 c3  c2   0.00 0.00 -120.0 0.00 0.00
//  patc firs none last none
//  
//  Resi HXE2       0.00 ! 2-hexene, yin/adm jr.
//  Group
//   Atom c1  ctl3 -0.27 !  H12 H13
//   Atom h11 HAL3  0.09 !    \ |
//   Atom h12 HAL3  0.09 ! H13-C1    H31 H51 H52
//   Atom h13 HAL3  0.09 !       \    /    \ /
//  Group                !        C2=C3    C5    H61
//   Atom c2  cel1 -0.15 !       /     \  /  \  /
//   Atom h21 HEL1  0.15 !     H21      C4    C6-H62
//  Group                !             / \      \
//   Atom c3  cel1 -0.15 !           H41 H42     H63
//   Atom h31 HEL1  0.15 !
//  Group
//   Atom c4  ctl2 -0.18
//   Atom h41 HAL2  0.09
//   Atom h42 HAL2  0.09
//  Group
//   Atom c5  ctl2 -0.18
//   Atom h51 HAL2  0.09
//   Atom h52 HAL2  0.09
//  Group
//   Atom c6  ctl3 -0.27
//   Atom h61 HAL3  0.09
//   Atom h62 HAL3  0.09
//   Atom h63 HAL3  0.09
//  
//  BOND c1 h11  c1 h12  c1 h13
//  BOND c1 c2
//  BOND c2 h21
//  DOUBLE c2 c3
//  BOND c3 h31
//  BOND c3 c4
//  BOND c4 h41  c4 h42
//  BOND c4 c5   c5 h51  c5 h52
//  BOND c5 c6   c6 h61  c6 h62  c6 h63
//  ! all trans
//  ic  c1   c2 c3  c4   0.00 0.00  180.0 0.00 0.00
//  ic  h11  c1 c2  c3   0.00 0.00    0.0 0.00 0.00
//  ic  h12  c1 c2  c3   0.00 0.00  120.0 0.00 0.00
//  ic  h13  c1 c2  c3   0.00 0.00 -120.0 0.00 0.00
//  ic  h21  c1 *c2 c3   0.00 0.00  180.0 0.00 0.00
//  ic  h31  c4 *c3 c2   0.00 0.00  120.0 0.00 0.00
//  ic  c2   c3 c4  c5   0.00 0.00  180.0 0.00 0.00
//  ic  c3   c5 *c4 h41  0.00 0.00  120.0 0.00 0.00
//  ic  c3   c5 *c4 h42  0.00 0.00 -120.0 0.00 0.00
//  ic  c3   c4 c5  c6   0.00 0.00  180.0 0.00 0.00
//  ic  c4   c6 *c5 h51  0.00 0.00  120.0 0.00 0.00
//  ic  c4   c6 *c5 h52  0.00 0.00 -120.0 0.00 0.00
//  ic  h61  c6 c5  c4   0.00 0.00  180.0 0.00 0.00
//  ic  h62  c6 c5  c4   0.00 0.00   60.0 0.00 0.00
//  ic  h63  c6 c5  c4   0.00 0.00  300.0 0.00 0.00
//  patc firs none last none
//  
//  !RESI TIP3         0.00 ! TIPS3P WATER MODEL
//  !                       ! GENERATE USING NOANGLE NODIHEDRAL
//  !GROUP                  !
//  !ATOM OH2  OT     -0.834
//  !ATOM H1   HT      0.417
//  !ATOM H2   HT      0.417
//  !BOND OH2  H1     OH2  H2    H1   H2    ! THE LAST BOND IS NEEDED FOR SHAKE
//  !ANGLE H1 OH2 H2    ! REQUIRED
//  !ACCEPTOR OH2
//  !PATCHING FIRS NONE LAST NONE
//   
//  !RESI TP3M         0.000 ! "mmff" water model, as an analog of tip3p
//  !GROUP   
//  !ATOM OH2  OT     -0.834  ! these charges are replaced by the mmff setup   
//  !ATOM H1   HT      0.417  ! these charges are replaced by the mmff setup
//  !ATOM H2   HT      0.417  ! these charges are replaced by the mmff setup
//  !BOND OH2 H1 OH2 H2          ! omits the H1-H2 bond, which is needed for shake with tip3p
//  !ANGLE H1 OH2 H2             ! required
//  !ACCEPTOR OH2   
//  !PATCHING FIRS NONE LAST NONE     
//  
//  RESI SOD          1.00 ! Sodium Ion
//  GROUP
//  ATOM SOD  SOD     1.00
//  PATCHING FIRST NONE LAST NONE
//   
//  RESI CLA         -1.00 ! Chloride Anion
//  GROUP
//  ATOM CLA  CLA    -1.00
//  PATCHING FIRST NONE LAST NONE
//   
//  RESI MG           2.00 ! Magnesium Ion
//  GROUP
//  ATOM MG   MG      2.00
//  PATCHING FIRST NONE LAST NONE
//   
//  !RESI DUM       0.00 ! DUMMY ATOM
//  !GROUP
//  !ATOM DUM DUM   0.00
//  !PATCHING FIRST NONE LAST NONE
//  
//  RESI NC4          1.00 ! tetramethylammonium
//  GROUP                  ! 
//  ATOM N    NTL    -0.60 !                H32
//  ATOM C1   CTL5   -0.35 !                 |
//  ATOM C2   CTL5   -0.35 !            H31-C3-H33
//  ATOM C3   CTL5   -0.35 !         H23     |      H41
//  ATOM C4   CTL5   -0.35 !         |       |      |
//  ATOM H11  HL      0.25 !     H22-C2------N------C4-H42    (+)
//  ATOM H12  HL      0.25 !         |       |      |
//  ATOM H13  HL      0.25 !         H21     |      H43
//  ATOM H21  HL      0.25 !            H11-C1-H13
//  ATOM H22  HL      0.25 !                 |
//  ATOM H23  HL      0.25 !                 H12
//  ATOM H31  HL      0.25
//  ATOM H32  HL      0.25
//  ATOM H33  HL      0.25
//  ATOM H41  HL      0.25
//  ATOM H42  HL      0.25
//  ATOM H43  HL      0.25
//  BOND N C1 N C2 N C3 N C4
//  BOND C1 H11 C1 H12 C1 H13
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  ! internal are wrong
//  IC C2   N    C1   H11   0.0000  0.0000  180.0000  0.0000  0.0000
//  IC C2   N    C1   H12   0.0000  0.0000  -60.0000  0.0000  0.0000
//  IC C2   N    C1   H13   0.0000  0.0000   60.0000  0.0000  0.0000
//  IC C2   C1   *N   C3    0.0000  0.0000  120.0000  0.0000  0.0000
//  IC C2   C1   *N   C4    0.0000  0.0000 -120.0000  0.0000  0.0000
//  IC C3   N    C2   H21   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C3   N    C2   H22   0.0000  0.0000 -120.0000  0.0000  0.0000
//  IC C3   N    C2   H23   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC C4   N    C3   H31   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C4   N    C3   H32   0.0000  0.0000 -120.0000  0.0000  0.0000
//  IC C4   N    C3   H33   0.0000  0.0000  120.0000  0.0000  0.0000
//  IC C1   N    C4   H41   0.0000  0.0000    0.0000  0.0000  0.0000
//  IC C1   N    C4   H42   0.0000  0.0000 -120.0000  0.0000  0.0000
//  IC C1   N    C4   H43   0.0000  0.0000  120.0000  0.0000  0.0000
//   
//  RESI NC5          1.00 ! tetramethylammonium ethyl analog 
//  GROUP
//  ATOM N    NTL    -0.60 !
//  ATOM C1   CTL2   -0.10 !                 |
//  ATOM C2   CTL5   -0.35 !               -C3-
//  ATOM C3   CTL5   -0.35 !                 |
//  ATOM C4   CTL5   -0.35 !            |    |   |
//  ATOM H11  HL      0.25 !           -C2---N---C4-     (+)
//  ATOM H12  HL      0.25 !            |    |   |
//  ATOM H21  HL      0.25 !                 |
//  ATOM H22  HL      0.25 !               -C1-
//  ATOM H23  HL      0.25 !                 |
//  ATOM H31  HL      0.25 !                 |
//  ATOM H32  HL      0.25 !               -C5-
//  ATOM H33  HL      0.25 !                 |
//  ATOM H41  HL      0.25
//  ATOM H42  HL      0.25
//  ATOM H43  HL      0.25
//  GROUP
//  ATOM C5   CTL3   -0.27
//  ATOM H51  HAL3    0.09
//  ATOM H52  HAL3    0.09
//  ATOM H53  HAL3    0.09
//  BOND N C1 N C2 N C3 N C4
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  BOND C5 H51 C5 H52 C5 H53
//  ! ab-initio HF/6-31G* structure
//  IC C4    N     C1    C5     1.4967  107.80  180.00  115.98   1.5217
//  IC C5    C1    N     C2     1.5217  115.98  -61.05  111.12   1.4950
//  IC C5    C1    N     C3     1.5217  115.98   61.05  111.12   1.4950
//  IC C4    N     C1    H11    1.4967  107.80   57.27  105.76   1.0809
//  IC C4    N     C1    H12    1.4967  107.80  -57.27  105.76   1.0809
//  IC C1    N     C2    H21    1.5176  111.12 -174.50  108.75   1.0795
//  IC C1    N     C2    H22    1.5176  111.12   65.81  109.69   1.0773
//  IC C1    N     C2    H23    1.5176  111.12  -54.79  109.07   1.0797
//  IC C1    N     C3    H31    1.5176  111.12  174.50  108.75   1.0795
//  IC C1    N     C3    H32    1.5176  111.12  -65.81  109.69   1.0773
//  IC C1    N     C3    H33    1.5176  111.12   54.79  109.07   1.0797
//  IC C1    N     C4    H41    1.5176  107.80  180.00  109.11   1.0793
//  IC C1    N     C4    H42    1.5176  107.80   60.03  109.12   1.0793
//  IC C1    N     C4    H43    1.5176  107.80  -60.03  109.12   1.0793
//  IC N     C1    C5    H51    1.5176  115.98  180.00  107.05   1.0836
//  IC N     C1    C5    H52    1.5176  115.98   62.29  112.91   1.0820
//  IC N     C1    C5    H53    1.5176  115.98  -62.29  112.91   1.0820
//  
//  RESI CHOL         1.00 ! choline
//  GROUP                  !
//  ATOM N    NTL    -0.60 !
//  ATOM C1   CTL2   -0.10 !                 |
//  ATOM C2   CTL5   -0.35 !               -C3-
//  ATOM C3   CTL5   -0.35 !                 |
//  ATOM C4   CTL5   -0.35 !            |    |   |
//  ATOM H11  HL      0.25 !           -C2---N---C4-     (+)
//  ATOM H12  HL      0.25 !            |    |   |
//  ATOM H21  HL      0.25 !                 |
//  ATOM H22  HL      0.25 !               -C1-
//  ATOM H23  HL      0.25 !                 |
//  ATOM H31  HL      0.25 !                 |
//  ATOM H32  HL      0.25 !                 |
//  ATOM H33  HL      0.25 !                 |
//  ATOM H41  HL      0.25 !                 |
//  ATOM H42  HL      0.25 !                 |
//  ATOM H43  HL      0.25 !                 |
//  GROUP                  !                 |
//  ATOM C5   CTL2    0.05 !                 |
//  ATOM H51  HAL2    0.09 !               -C5-
//  ATOM H52  HAL2    0.09 !                 |
//  ATOM OH1  OHL    -0.66 !                 OH1---HO1
//  ATOM HO1  HOL     0.43 !
//  BOND N C1 N C2 N C3 N C4
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  BOND C5 H51 C5 H52
//  BOND C5 OH1 OH1 HO1
//  ! ab-initio HF/6-31G* geometry  of gauche conformer
//  IC C4    N     C1    C5     1.4964  107.76  161.60  116.58   1.5208
//  IC C5    C1    N     C2     1.5208  116.58  -80.13  111.04   1.5031
//  IC C5    C1    N     C3     1.5208  116.58   42.05  111.71   1.4945
//  IC N     C1    C5    OH1    1.5158  116.58   56.02  109.57   1.3947
//  IC C1    C5    OH1   HO1    1.5208  109.57  169.05  110.84   0.9491
//  IC C2    N     C1    H11    1.5031  111.04  158.76  106.72   1.0813
//  IC C3    N     C1    H12    1.4945  111.71  165.25  106.14   1.0802
//  IC C1    N     C2    H21    1.5158  111.04 -179.38  108.21   1.0796
//  IC C3    N     C2    H22    1.4945  109.20  -63.85  109.22   1.0746
//  IC C4    N     C2    H23    1.4964  108.15   57.69  108.56   1.0794
//  IC C1    N     C3    H31    1.5158  111.71  173.42  108.53   1.0794
//  IC C2    N     C3    H32    1.5031  109.20  177.22  109.23   1.0800
//  IC C4    N     C3    H33    1.4964  108.88  174.14  109.12   1.0773
//  IC C1    N     C4    H41    1.5158  107.76  175.04  109.01   1.0793
//  IC C2    N     C4    H42    1.5031  108.15  -64.86  109.05   1.0796
//  IC C3    N     C4    H43    1.4945  108.88   56.40  109.30   1.0794
//  IC N     C1    C5    H51    1.5158  116.58  176.61  105.66   1.0855
//  IC N     C1    C5    H52    1.5158  116.58  -67.32  110.89   1.0847
//   
//  RESI ACHO         1.00 ! acetylcholine
//  GROUP                  !
//  ATOM N    NTL    -0.60 !
//  ATOM C1   CTL2   -0.10 !                 |
//  ATOM C2   CTL5   -0.35 !               -C3-
//  ATOM C3   CTL5   -0.35 !                 |
//  ATOM C4   CTL5   -0.35 !            |    |   |
//  ATOM H11  HL      0.25 !           -C2---N---C4-     (+)
//  ATOM H12  HL      0.25 !            |    |   |
//  ATOM H21  HL      0.25 !                 |
//  ATOM H22  HL      0.25 !               -C1-
//  ATOM H23  HL      0.25 !                 |
//  ATOM H31  HL      0.25 !                 |
//  ATOM H32  HL      0.25 !                 |
//  ATOM H33  HL      0.25 !                 |
//  ATOM H41  HL      0.25 !                 |
//  ATOM H42  HL      0.25 !                 |
//  ATOM H43  HL      0.25 !                 |
//  GROUP                  !                 |  
//  ATOM C5   CTL2   -0.05 !               -C5- 
//  ATOM OM   OSL    -0.34 !                 |  
//  ATOM C    CL      0.63 !                OM
//  ATOM C7   CTL3   -0.17 !                /
//  ATOM O    OBL    -0.52 !            O==C
//  ATOM H51  HAL2    0.09 !               |
//  ATOM H52  HAL2    0.09 !             --C7--
//  ATOM H71  HAL3    0.09 !               |
//  ATOM H72  HAL3    0.09 !
//  ATOM H73  HAL3    0.09 !
//  BOND N C1   N C2   N C3   N C4
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  BOND C5 H51 C5 H52
//  BOND C7   C       C    OM      OM    C5
//  DOUBLE C   O
//  BOND C7   H71     C7   H72     C7   H73
//  IMPR C OM C7 O
//  IC C4    N     C1    C5     0.0000  000.00  161.60  000.00   0.0000
//  IC C5    C1    N     C2     0.0000  000.00  -80.13  000.00   0.0000
//  IC C5    C1    N     C3     0.0000  000.00   42.05  000.00   0.0000
//  IC C2    N     C1    H11    0.0000  000.00  158.76  000.00   0.0000
//  IC C3    N     C1    H12    0.0000  000.00  165.25  000.00   0.0000
//  IC C1    N     C2    H21    0.0000  000.00 -179.38  000.00   0.0000
//  IC C3    N     C2    H22    0.0000  000.00  -63.85  000.00   0.0000
//  IC C4    N     C2    H23    0.0000  000.00   57.69  000.00   0.0000
//  IC C1    N     C3    H31    0.0000  000.00  173.42  000.00   0.0000
//  IC C2    N     C3    H32    0.0000  000.00  177.22  000.00   0.0000
//  IC C4    N     C3    H33    0.0000  000.00  174.14  000.00   0.0000
//  IC C1    N     C4    H41    0.0000  000.00  175.04  000.00   0.0000
//  IC C2    N     C4    H42    0.0000  000.00  -64.86  000.00   0.0000
//  IC C3    N     C4    H43    0.0000  000.00   56.40  000.00   0.0000
//  IC N     C1    C5    H51    0.0000  000.00  180.00  000.00   0.0000
//  IC N     C1    C5    H52    0.0000  000.00  -60.0   000.00   0.0000
//  IC N     C1    C5    OM     0.0000  000.00   72.0   000.00   0.0000
//  IC C1    C5    OM    C      0.0000  000.00  166.9   000.00   0.0000
//  IC C7    C     OM    C5     0.0000  000.00   20.0   000.00   0.0000
//  IC O     C     OM    C5     0.0000  000.00 -160.0   000.00   0.0000
//  IC H71   C7    C     OM     0.0000  000.00  180.0   000.00   0.0000
//  IC H72   C7    C     OM     0.0000  000.00   60.4   000.00   0.0000
//  IC H73   C7    C     OM     0.0000  000.00  -60.4   000.00   0.0000
//   
//  RESI PC           0.00 ! phosphatidylcholine
//  GROUP                  !
//  ATOM N    NTL    -0.60 !
//  ATOM C1   CTL2   -0.10 !                 |
//  ATOM C2   CTL5   -0.35 !               -C3-
//  ATOM C3   CTL5   -0.35 !                 |
//  ATOM C4   CTL5   -0.35 !            |    |   |
//  ATOM H11  HL      0.25 !           -C2---N---C4-     (+)
//  ATOM H12  HL      0.25 !            |    |   |
//  ATOM H21  HL      0.25 !                 |
//  ATOM H22  HL      0.25 !               -C1-
//  ATOM H23  HL      0.25 !                 |
//  ATOM H31  HL      0.25 !                 |
//  ATOM H32  HL      0.25 !                 |
//  ATOM H33  HL      0.25 !                 |
//  ATOM H41  HL      0.25 !                 |
//  ATOM H42  HL      0.25 !                 |
//  ATOM H43  HL      0.25 !                 |
//  GROUP                  !                 |
//  ATOM C5   CTL2   -0.08 !                 |
//  ATOM H51  HAL2    0.09 !          H52---C5---H51
//  ATOM H52  HAL2    0.09 !                 |
//  GROUP                  !                 |
//  ATOM P1   PL      1.50 !       (-) O3   O1
//  ATOM O3   O2L    -0.78 !             \ /
//  ATOM O4   O2L    -0.78 !              P1 (+)
//  ATOM O1   OSL    -0.57 !             / \
//  ATOM O2   OSL    -0.57 !       (-) O4   O2
//  GROUP                  !                 |
//  ATOM C6   CTL3   -0.17 !                 |
//  ATOM H61  HAL3    0.09 !            H63-C6-H62
//  ATOM H62  HAL3    0.09 !                 |
//  ATOM H63  HAL3    0.09 !                H61
//                         !
//  BOND N C1 N C2 N C3 N C4
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  BOND C5 H51 C5 H52
//  BOND P1   O1     P1   O2    P1   O3    P1   O4    O1   C5    O2   C6
//  BOND C6   H61    C6   H62   C6   H63
//  
//  IC C4    N     C1    C5     0.0000  000.00  112.00  000.00   0.0000
//  IC C5    C1    N     C2     0.0000  000.00 -121.00  000.00   0.0000
//  IC C5    C1    N     C3     0.0000  000.00    0.00  000.00   0.0000
//  IC C2    N     C1    H11    0.0000  000.00  120.00  000.00   0.0000
//  IC C3    N     C1    H12    0.0000  000.00  120.00  000.00   0.0000
//  IC C1    N     C2    H21    0.0000  000.00  180.00  000.00   0.0000
//  IC C3    N     C2    H22    0.0000  000.00  -60.00  000.00   0.0000
//  IC C4    N     C2    H23    0.0000  000.00   60.00  000.00   0.0000
//  IC C1    N     C3    H31    0.0000  000.00  180.00  000.00   0.0000
//  IC C2    N     C3    H32    0.0000  000.00  180.00  000.00   0.0000
//  IC C4    N     C3    H33    0.0000  000.00  180.00  000.00   0.0000
//  IC C1    N     C4    H41    0.0000  000.00  180.00  000.00   0.0000
//  IC C2    N     C4    H42    0.0000  000.00  -60.00  000.00   0.0000
//  IC C3    N     C4    H43    0.0000  000.00   60.00  000.00   0.0000
//  IC N     C1    C5    H51    0.0000  000.00 -150.00  000.00   0.0000
//  IC N     C1    C5    H52    0.0000  000.00  100.00  000.00   0.0000
//  IC N     C1    C5    O1     0.0000  000.00  -30.00  000.00   0.0000
//  IC C1    C5    O1    P1     0.0000  000.00  130.00  000.00   0.0000
//  IC C5    O1    P1    O2     0.0000  000.00 -160.0   000.00   0.0000
//  IC O3    P1    O1    C5     0.0000  000.00   80.00  000.00   0.0000
//  IC O4    P1    O1    C5     0.0000  000.00  -60.00  000.00   0.0000
//  IC O1    P1    O2    C6     0.0000  000.00  180.00  000.00   0.0000
//  IC H61   C6    O2    P1     0.0000  000.00    0.00  000.00   0.0000
//  IC H62   C6    O2    P1     0.0000  000.00  120.00  000.00   0.0000
//  IC H63   C6    O2    P1     0.0000  000.00 -120.00  000.00   0.0000
//    
//  RESI GPC          0.00 ! glycerolphosphorylcholine
//  GROUP                  !
//  ATOM N    NTL    -0.60 !
//  ATOM C1   CTL2   -0.10 !             |
//  ATOM C2   CTL5   -0.35 !           -C3-
//  ATOM C3   CTL5   -0.35 !             |
//  ATOM C4   CTL5   -0.35 !        |    |   |
//  ATOM H11  HL      0.25 !       -C2---N---C4-     (+)
//  ATOM H12  HL      0.25 !        |    |   |
//  ATOM H21  HL      0.25 !             |
//  ATOM H22  HL      0.25 !           -C1-
//  ATOM H23  HL      0.25 !             |
//  ATOM H31  HL      0.25 !             |
//  ATOM H32  HL      0.25 !             |
//  ATOM H33  HL      0.25 !             |
//  ATOM H41  HL      0.25 !             |
//  ATOM H42  HL      0.25 !             |
//  ATOM H43  HL      0.25 !             |
//  GROUP                  !             |
//  ATOM C5   CTL2   -0.08 !             |
//  ATOM H51  HAL2    0.09 !       H51---C5---H52
//  ATOM H52  HAL2    0.09 !             |
//  ATOM P    PL      1.50 !    (-) O3   O1
//  ATOM O3   O2L    -0.78 !          \ /
//  ATOM O4   O2L    -0.78 !           P (+)
//  ATOM O1   OSL    -0.57 !          / \
//  ATOM O2   OSL    -0.57 !    (-) O4   O2
//  ATOM CG1  CTL2   -0.08 !             |
//  ATOM HG11 HAL2    0.09 !        HG11-CG1-HG12
//  ATOM HG12 HAL2    0.09 !             |
//  GROUP                  !             | 
//  ATOM CG2  CTL1    0.14 !             |
//  ATOM HG21 HAL1    0.09 !        HG21-CG2-OG2-HO2
//  ATOM OG2  OHL    -0.66 !             |
//  ATOM HO2  HOL     0.43 !             |       
//  GROUP                  !             |  
//  ATOM CG3  CTL2    0.05 !             |
//  ATOM HG31 HAL2    0.09 !        HG31-CG3-OG3-HO3
//  ATOM HG32 HAL2    0.09 !             |
//  ATOM OG3  OHL    -0.66 !             HG32
//  ATOM HO3  HOL     0.43 !
//  BOND CG1 O2   CG1 HG11  CG1 HG12
//  BOND CG2 CG1  CG2 HG21  CG2 OG2   OG2 HO2
//  BOND CG3 CG2  CG3 HG31  CG3 HG32  CG3 OG3  OG3 HO3
//  BOND N   C1   N   C2    N   C3    N   C4
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C2 H21 C2 H22 C2 H23
//  BOND C3 H31 C3 H32 C3 H33
//  BOND C4 H41 C4 H42 C4 H43
//  BOND C5 H51 C5 H52
//  BOND P   O1   P   O2    P   O3    P   O4    O1   C5
//  
//  ! internal coordinates for analysis
//  ! see H.Hauser,I.Pascher,R.H.Pearson,S.Sundell, BBA 650, 21-51 (1981)
//  !  glycerol backbone
//  IC O2   CG1  CG2  CG3   0.      0.        0.      0.      0. !  t1
//  IC O2   CG1  CG2  OG2   0.      0.        0.      0.      0. !  t2
//  IC CG1  CG2  CG3  OG3   0.      0.        0.      0.      0. !  t3
//  IC OG2  CG2  CG3  OG3   0.      0.        0.      0.      0. !  t3
//  !
//  !  zwitterionic headgroup
//  IC P    O2   CG1  CG2   0.      0.        0.      0.      0. !  a1
//  IC O1   P    O2   CG1   0.      0.        0.      0.      0. !  a2
//  IC O2   P    O1   C5    0.      0.        0.      0.      0. !  a3
//  IC C1   C5   O1   P     0.      0.        0.      0.      0. !  a4
//  IC N    C1   C5   O1    0.      0.        0.      0.      0. !  a5
//  IC C2   N    C1   C5    0.      0.        0.      0.      0. !  a6
//  IC C3   N    C1   C5    0.      0.        0.      0.      0. !  a6
//  IC C4   N    C1   C5    0.      0.        0.      0.      0. !  a6
//  IC O1   O2   *P   O3    0.      0.      120.      0.      0. 
//  IC O1   O2   *P   O4    0.      0.     -120.      0.      0. 
//    
//  RESI LPPC        0.00 ! deoxylysophosphatidylcholine 
//  ! Polar Head and glycerol backbone
//  GROUP                 !          H15B
//  ATOM N    NTL   -0.60 !            |
//  ATOM C13  CTL5  -0.35 !      H15A-C15-H15C
//  ATOM H13A HL     0.25 !            | 
//  ATOM H13B HL     0.25 !    H13B    |    H14A
//  ATOM H13C HL     0.25 !      |     |     |
//  ATOM C14  CTL5  -0.35 !H13A-C13----N----C14-H14B     (+)
//  ATOM H14A HL     0.25 !      |     |     |
//  ATOM H14B HL     0.25 !    H13C    |    H14C
//  ATOM H14C HL     0.25 !            |
//  ATOM C15  CTL5  -0.35 !            |
//  ATOM H15A HL     0.25 !            |    alpha6
//  ATOM H15B HL     0.25 !            |  
//  ATOM H15C HL     0.25 !            |
//  ATOM C12  CTL2  -0.10 !     H12A--C12---H12B     
//  ATOM H12A HL     0.25 !            |
//  ATOM H12B HL     0.25 !            |    
//  GROUP                 !                  alpha5
//  ATOM C11  CTL2  -0.08 !            |
//  ATOM H11A HAL2   0.09 !     H11A--C11---H11B
//  ATOM H11B HAL2   0.09 !            |     alpha4
//  ATOM P    PL     1.50 !   (-) O13  O12
//  ATOM O13  O2L   -0.78 !         \ /      alpha3
//  ATOM O14  O2L   -0.78 !          P (+)
//  ATOM O11  OSL   -0.57 !         / \      alpha2
//  ATOM O12  OSL   -0.57 !   (-) O14  O11
//  ATOM C1   CTL2  -0.08 !            |     alpha1
//  ATOM HA   HAL2   0.09 !       HA---C1---HB
//  ATOM HB   HAL2   0.09 !            |     theta1
//  GROUP                 !            |
//  ATOM C2   CTL2  -0.18 !       HR---C2----HS
//  ATOM HS   HAL2   0.09 !            | 
//  ATOM HR   HAL2   0.09 !            | 
//  GROUP                 !            |
//  ATOM C3   CTL2  -0.05 !       HX---C3---HY 
//  ATOM HX   HAL2   0.09 !            |
//  ATOM HY   HAL2   0.09 !            |   gamma1
//  ATOM O31  OSL   -0.34 !      O32  O31
//  ATOM C31  CL     0.63 !       \\ /    gamma2
//  ATOM O32  OBL   -0.52 !        C31
//  ATOM C32  CTL2  -0.08 !         |     gamma3
//  ATOM H2X  HAL2   0.09 !  H2X---C32---H2Y
//  ATOM H2Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C33  CTL2  -0.18 !         |
//  ATOM H3X  HAL2   0.09 !  H3X---C33---H3Y 
//  ATOM H3Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C34  CTL2  -0.18 !         |
//  ATOM H4X  HAL2   0.09 !  H4X---C34---H4Y
//  ATOM H4Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C35  CTL2  -0.18 !         |
//  ATOM H5X  HAL2   0.09 !  H5X---C35---H5Y
//  ATOM H5Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C36  CTL2  -0.18 !         |
//  ATOM H6X  HAL2   0.09 !  H6X---C36---H6Y
//  ATOM H6Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C37  CTL2  -0.18 !         |
//  ATOM H7X  HAL2   0.09 !  H7X---C37---H7Y
//  ATOM H7Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C38  CTL2  -0.18 !         |
//  ATOM H8X  HAL2   0.09 !  H8X---C38---H8Y
//  ATOM H8Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C39  CTL2  -0.18 !         |
//  ATOM H9X  HAL2   0.09 !  H9X---C39---H9Y 
//  ATOM H9Y  HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C310 CTL2  -0.18 !         |
//  ATOM H10X HAL2   0.09 ! H10X---C310--H10Y
//  ATOM H10Y HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C311 CTL2  -0.18 !         |
//  ATOM H11X HAL2   0.09 ! H11X---C311--H11Y
//  ATOM H11Y HAL2   0.09 !         |
//  GROUP                 !
//  ATOM C312 CTL3  -0.27 !         |
//  ATOM H12X HAL3   0.09 ! H12X---C312--H12Y
//  ATOM H12Y HAL3   0.09 !         |
//  ATOM H12Z HAL3   0.09 !        H12Z
//                        !
//  ! Polar Head
//  BOND  N    C13       N    C14       N    C15       
//  BOND  C13  H13A      C13  H13B      C13  H13C 
//  BOND  C14  H14A      C14  H14B      C14  H14C 
//  BOND  C15  H15A      C15  H15B      C15  H15C 
//  BOND  N    C12
//  BOND  C12  H12A      C12  H12B      C12  C11
//  BOND  C11  H11A      C11  H11B      C11  O12   
//  BOND  O12  P         P    O11       P    O13       P    O14 
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        C1   O11       
//  BOND  C2   HS        C2    HR       C2   C3
//  BOND  C3   HX        C3    HY       C3   O31
//  
//  ! Chain #3
//  BOND  O31  C31
//  BOND  C31  C32
//  DOUBLE  C31  O32
//  BOND  C32  H2X       C32  H2Y       C32  C33 
//  BOND  C33  H3X       C33  H3Y       C33  C34 
//  BOND  C34  H4X       C34  H4Y       C34  C35 
//  BOND  C35  H5X       C35  H5Y       C35  C36 
//  BOND  C36  H6X       C36  H6Y       C36  C37 
//  BOND  C37  H7X       C37  H7Y       C37  C38 
//  BOND  C38  H8X       C38  H8Y       C38  C39 
//  BOND  C39  H9X       C39  H9Y       C39  C310
//  BOND  C310 H10X      C310 H10Y      C310 C311
//  BOND  C311 H11X      C311 H11Y      C311 C312
//  BOND  C312 H12X      C312 H12Y      C312 H12Z
//  
//  IMPR C31 O31 C32 O32 
//  
//  ! Polar head (angle names from Sundaralingam)
//  IC       C2    C1    O11   P      0.0  0.0  180.0  0.0  0.0 !alpha1
//  IC       C1    O11   P     O12    0.0  0.0  180.0  0.0  0.0 !alpha2
//  IC       O11   O12  *P     O13    0.0  0.0  120.0  0.0  0.0
//  IC       O11   O12  *P     O14    0.0  0.0  240.0  0.0  0.0
//  IC       O11   P     O12   C11    0.0  0.0  180.0  0.0  0.0 !alpha3
//  IC       O12   C12  *C11   H11A   0.0  0.0  120.0  0.0  0.0
//  IC       O12   C12  *C11   H11B   0.0  0.0  240.0  0.0  0.0
//  IC       P     O12   C11   C12    0.0  0.0  180.0  0.0  0.0 !alpha4
//  IC       N     C11  *C12   H12A   0.0  0.0  120.0  0.0  0.0
//  IC       N     C11  *C12   H12B   0.0  0.0  240.0  0.0  0.0
//  IC       O12   C11   C12   N      0.0  0.0  180.0  0.0  0.0 !alpha5
//  IC       C11   C12   N     C13    0.0  0.0  180.0  0.0  0.0 !alpha6
//  IC       C12   C13  *N     C14    0.0  0.0  120.0  0.0  0.0
//  IC       C12   C13  *N     C15    0.0  0.0  240.0  0.0  0.0
//  
//  ! Glycerol
//  IC       O11   C1    C2    C3     0.0  0.0  120.0  0.0  0.0 !theta1
//  IC       C1    C2    C3    O31    0.0  0.0  180.0  0.0  0.0 !theta3
//  
//  ! Chain 3
//  IC       C2    C3    O31   C31    0.0  0.0 -120.0  0.0  0.0 !gamma1
//  IC       C3    O31   C31   C32    0.0  0.0  180.0  0.0  0.0 !gamma2
//  IC       O31   C31   C32   C33    0.0  0.0  180.0  0.0  0.0 !gamma3
//  IC       C32   O31  *C31   O32    0.0  0.0  180.0  0.0  0.0
//  IC       C31   C32   C33   C34    0.0  0.0  180.0  0.0  0.0 !gamma4
//  IC       C32   C33   C34   C35    0.0  0.0  180.0  0.0  0.0 !gamma5
//  IC       C33   C34   C35   C36    0.0  0.0  180.0  0.0  0.0 !gamma6
//  IC       C34   C35   C36   C37    0.0  0.0  180.0  0.0  0.0 !gamma7
//  IC       C35   C36   C37   C38    0.0  0.0  180.0  0.0  0.0 !gamma8
//  IC       C36   C37   C38   C39    0.0  0.0  180.0  0.0  0.0 !gamma9
//  IC       C37   C38   C39   C310   0.0  0.0  180.0  0.0  0.0 !gamma10
//  IC       C38   C39   C310  C311   0.0  0.0  180.0  0.0  0.0 !gamma11
//  IC       C39   C310  C311  C312   0.0  0.0  180.0  0.0  0.0 !gamma12
//  
//  RESI ETAM       1.00 ! ethanolamine
//  GROUP                !
//  ATOM N    NH3L -0.30 !           HN2
//  ATOM HN1  HCL   0.33 !            |
//  ATOM HN2  HCL   0.33 !  (+) HN1---N---HN3
//  ATOM HN3  HCL   0.33 !            |
//  ATOM C1   CTL2  0.13 !            |
//  ATOM H11  HAL2  0.09 !     H12---C1---H11
//  ATOM H12  HAL2  0.09 !            |
//  GROUP                !            |
//  ATOM C5   CTL2  0.05 !            |
//  ATOM H51  HAL2  0.09 !      H52---C5---H51
//  ATOM H52  HAL2  0.09 !            |
//  ATOM OH1  OHL  -0.66 !            OH1---HO1
//  ATOM HO1  HOL   0.43 !
//  BOND N HN1 N HN2 N HN3 N C1
//  BOND C1 H11 C1 H12 C1 C5
//  BOND C5 H51 C5 H52
//  BOND C5 OH1 OH1 HO1
//  ! HF/6-31G* OPTIMIZED STRUCTURE:
//  IC N    C1    C5    OH1    1.5084  107.86   48.44  104.92   1.3987
//  IC C1   C5    OH1   HO1    1.5191  104.92  173.19  111.99   0.9495
//  IC HN1  N     C1    C5     1.0145  108.35  -49.03  107.86   1.5191
//  IC HN2  N     C1    C5     1.0107  112.05   69.23  107.86   1.5191
//  IC HN3  N     C1    C5     1.0102  112.39 -169.37  107.86   1.5191
//  IC N    C5    *C1   H11    0.0000  000.00  120.00  000.00   0.0000
//  IC N    C5    *C1   H12    0.0000  000.00 -120.00  000.00   0.0000
//  IC OH1  C1    *C5   H51    0.0000  000.00  120.00  000.00   0.0000
//  IC OH1  C1    *C5   H52    0.0000  000.00 -120.00  000.00   0.0000
//  
//  RESI GPE          0.00 ! L-alpha-glycerylphosphorylethanolamine
//  !
//  GROUP                  !
//  ATOM N     NH3L  -0.30 !           HN2
//  ATOM HN1   HCL    0.33 !            |
//  ATOM HN2   HCL    0.33 !  (+) HN1---N---HN3
//  ATOM HN3   HCL    0.33 !            |
//  ATOM C12   CTL2   0.13 !            |
//  ATOM H12A  HAL2   0.09 !     H12A--C12---H12B
//  ATOM H12B  HAL2   0.09 !            |
//  GROUP                  !            |     alpha5
//  ATOM C11  CTL2   -0.08 !            |
//  ATOM H11A HAL2    0.09 !     H11A--C11---H11B
//  ATOM H11B HAL2    0.09 !            |     alpha4
//  ATOM P    PL      1.50 !   (-) O13  O12
//  ATOM O13  O2L    -0.78 !         \ /      alpha3
//  ATOM O14  O2L    -0.78 !          P (+)
//  ATOM O11  OSL    -0.57 !         / \      alpha2
//  ATOM O12  OSL    -0.57 !   (-) O14  O11
//  ATOM C1   CTL2   -0.08 !            |     alpha1
//  ATOM HA   HAL2    0.09 !       HA---C1---HB
//  ATOM HB   HAL2    0.09 !            |     theta1
//  GROUP                  !            | 
//  ATOM C2  CTL1     0.14 !            |
//  ATOM HS  HAL1     0.09 !         HS-C2-OH2-HO2
//  ATOM OH2  OHL    -0.66 !            |
//  ATOM HO2  HOL     0.43 !            |       
//  GROUP                  !            |  
//  ATOM C3  CTL2     0.05 !            |
//  ATOM HX  HAL2     0.09 !         HX-C3-OH3-HO3
//  ATOM HY  HAL2     0.09 !            |
//  ATOM OH3  OHL    -0.66 !            HY
//  ATOM HO3  HOL     0.43 !
//  ! Polar Head
//  BOND  N    HN1       N    HN2       N    HN3       N    C12
//  BOND  C12  H12A      C12  H12B      C12  C11
//  BOND  C11  H11A      C11  H11B      C11  O12
//  BOND  O12  P         P    O11       P    O13       P    O14
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        C1   O11
//  BOND  C2   HS        C2    C3       C2   OH2
//  BOND  C3   HX        C3    HY       C3   OH3
//  BOND  OH2  HO2
//  BOND  OH3  HO3
//  !
//  ! Polar head (angle names from Sundaralingam)
//  IC       C2    C1    O11   P      0.0  0.0  180.0  0.0  0.0 !alpha1
//  IC       C1    O11   P     O12    0.0  0.0  180.0  0.0  0.0 !alpha2
//  IC       O11   O12  *P     O13    0.0  0.0  120.0  0.0  0.0
//  IC       O11   O12  *P     O14    0.0  0.0  240.0  0.0  0.0
//  IC       O11   P     O12   C11    0.0  0.0  180.0  0.0  0.0 !alpha3
//  IC       O12   C12  *C11   H11A   0.0  0.0  120.0  0.0  0.0
//  IC       O12   C12  *C11   H11B   0.0  0.0  240.0  0.0  0.0
//  IC       P     O12   C11   C12    0.0  0.0  180.0  0.0  0.0 !alpha4
//  IC       N     C11  *C12   H12A   0.0  0.0  120.0  0.0  0.0
//  IC       N     C11  *C12   H12B   0.0  0.0  240.0  0.0  0.0
//  IC       O12   C11   C12   N      0.0  0.0  180.0  0.0  0.0 !alpha5
//  IC       C11   C12   N     HN1    0.0  0.0  180.0  0.0  0.0 !alpha6
//  IC       C12   HN1  *N     HN2    0.0  0.0  120.0  0.0  0.0
//  IC       C12   HN1  *N     HN3    0.0  0.0  240.0  0.0  0.0
//  ! Glycerol
//  IC       O11   C1    C2    C3     0.0  0.0  120.0  0.0  0.0 !theta1
//  IC       C1    C2    C3    OH3    0.0  0.0  180.0  0.0  0.0 !theta3
//  IC       C1    C3   *C2    OH2    0.0  0.0 -120.0  0.0  0.0
//  ! for stereo-specific phopholipid at carbon C2 (labeled hydrogen S)
//  IC       O11   C2   *C1    HA     0.0  0.0 +120.0  0.0  0.0
//  IC       O11   C2   *C1    HB     0.0  0.0 -120.0  0.0  0.0
//  IC       OH2   C1   *C2    HS     0.0  0.0 +120.0  0.0  0.0
//  IC       OH3   C2   *C3    HX     0.0  0.0 +120.0  0.0  0.0
//  IC       OH3   C2   *C3    HY     0.0  0.0 -120.0  0.0  0.0
//  IC       C1    C2    OH2   HO2    0.0  0.0  180.0  0.0  0.0 !beta1
//  IC       C2    C3    OH3   HO3    0.0  0.0 -120.0  0.0  0.0 !gamma1
//  
//  RESI DLPE         0.00 ! 1,2 dilauroyl-DL-Phosphatidylethanolamine
//  !
//  !  R1 - CH2        
//  !       |          (angles and atom names from Sundaralingam)
//  !  R2 - CH
//  !       |
//  !       CH2 - PO4 - CH2 - CH2 - NH3
//  !
//  ! Polar Head and glycerol backbone
//  GROUP                  !
//  ATOM N     NH3L  -0.30 !           HN2
//  ATOM HN1   HCL    0.33 !            |
//  ATOM HN2   HCL    0.33 !  (+) HN1---N---HN3
//  ATOM HN3   HCL    0.33 !            |
//  ATOM C12   CTL2   0.13 !            |
//  ATOM H12A  HAL2   0.09 !     H12A--C12---H12B
//  ATOM H12B  HAL2   0.09 !            |
//  GROUP                  !            |     alpha5
//  ATOM C11  CTL2   -0.08 !            |
//  ATOM H11A HAL2    0.09 !     H11A--C11---H11B
//  ATOM H11B HAL2    0.09 !            |     alpha4
//  ATOM P    PL      1.50 !   (-) O13  O12
//  ATOM O13  O2L    -0.78 !         \ /      alpha3
//  ATOM O14  O2L    -0.78 !          P (+)
//  ATOM O11  OSL    -0.57 !         / \      alpha2
//  ATOM O12  OSL    -0.57 !   (-) O14  O11
//  ATOM C1   CTL2   -0.08 !            |     alpha1
//  ATOM HA   HAL2    0.09 !      H1A---C1---H1B
//  ATOM HB   HAL2    0.09 !            |     theta1
//  GROUP                  !            |
//  ATOM C2   CTL1    0.04 !       HS---C2- - - - - - -
//  ATOM HS   HAL1    0.09 !            | beta1        |
//  ATOM O21  OSL    -0.34 !       O22  O21          theta3
//  ATOM C21  CL      0.63 !        \\ /  beta2        |
//  ATOM O22  OBL    -0.52 !          C21
//  ATOM C22  CTL2   -0.08 !          |   beta3        |
//  ATOM H2R  HAL2    0.09 !   H2R---C22---H2S
//  ATOM H2S  HAL2    0.09 !          |                |
//  GROUP                  !              beta4
//  ATOM C3   CTL2   -0.05 !          |                |
//  ATOM HX   HAL2    0.09 !                      HX---C3---HY
//  ATOM HY   HAL2    0.09 !          |                |   gamma1
//  ATOM O31  OSL    -0.34 !                      O32  O31
//  ATOM C31  CL      0.63 !          |            \\ /    gamma2
//  ATOM O32  OBL    -0.52 !                         C31
//  ATOM C32  CTL2   -0.08 !          |              |     gamma3
//  ATOM H2X  HAL2    0.09 !                  H2X---C32---H2Y
//  ATOM H2Y  HAL2    0.09 !          |              |
//  GROUP                  !                               gamma4
//  ATOM C23  CTL2   -0.18 !          |              |
//  ATOM H3R  HAL2    0.09 !   H3R ---C23---H3S
//  ATOM H3S  HAL2    0.09 !          |              |
//  GROUP                  !
//  ATOM C24  CTL2   -0.18 !          |
//  ATOM H4R  HAL2    0.09 !   H4R ---C24---H4S      |
//  ATOM H4S  HAL2    0.09 !          |
//  GROUP                  !
//  ATOM C25  CTL2   -0.18 !          |              |
//  ATOM H5R  HAL2    0.09 !   H5R ---C25---H5S
//  ATOM H5S  HAL2    0.09 !          |              |
//  GROUP                  !
//  ATOM C26  CTL2   -0.18 !          |
//  ATOM H6R  HAL2    0.09 !   H6R ---C26---H6S      |
//  ATOM H6S  HAL2    0.09 !          |
//  GROUP                  !
//  ATOM C27  CTL2   -0.18 !          |              |
//  ATOM H7R  HAL2    0.09 !   H7R ---C27---H7S
//  ATOM H7S  HAL2    0.09 !          |              |
//  GROUP                  !
//  ATOM C28  CTL2   -0.18 !          |
//  ATOM H8R  HAL2    0.09 !   H8R ---C28---H8S      |
//  ATOM H8S  HAL2    0.09 !          |
//  GROUP                  !
//  ATOM C29  CTL2   -0.18 !          |              |
//  ATOM H9R  HAL2    0.09 !   H9R ---C29---H9S
//  ATOM H9S  HAL2    0.09 !          |              |
//  GROUP                  !
//  ATOM C210 CTL2   -0.18 !          |
//  ATOM H10R HAL2    0.09 !   H10R---C210--H10S     |
//  ATOM H10S HAL2    0.09 !          |
//  GROUP                  !
//  ATOM C211 CTL2   -0.18 !          |              |
//  ATOM H11R HAL2    0.09 !   H11R---C211--H11S
//  ATOM H11S HAL2    0.09 !          |              |
//  GROUP                  !
//  ATOM C212 CTL3   -0.27 !          |
//  ATOM H12R HAL3    0.09 !   H12R---C212--H12S     |
//  ATOM H12S HAL3    0.09 !          |
//  ATOM H12T HAL3    0.09 !         H12T            |
//  GROUP                  !
//  ATOM C33  CTL2   -0.18 !                         |
//  ATOM H3X  HAL2    0.09 !                  H3X ---C33---H3Y
//  ATOM H3Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C34  CTL2   -0.18 !                         |
//  ATOM H4X  HAL2    0.09 !                  H4X ---C34---H4Y
//  ATOM H4Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C35  CTL2   -0.18 !                         |
//  ATOM H5X  HAL2    0.09 !                  H5X ---C35---H5Y
//  ATOM H5Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C36  CTL2   -0.18 !                         |
//  ATOM H6X  HAL2    0.09 !                  H6X ---C36---H6Y
//  ATOM H6Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C37  CTL2   -0.18 !                         |
//  ATOM H7X  HAL2    0.09 !                  H7X ---C37---H7Y
//  ATOM H7Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C38  CTL2   -0.18 !                         |
//  ATOM H8X  HAL2    0.09 !                  H8X ---C38---H8Y
//  ATOM H8Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C39  CTL2   -0.18 !                         |
//  ATOM H9X  HAL2    0.09 !                  H9X ---C39---H9Y
//  ATOM H9Y  HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C310 CTL2   -0.18 !                         |
//  ATOM H10X HAL2    0.09 !                  H10X---C310--H10Y
//  ATOM H10Y HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C311 CTL2   -0.18 !                         |
//  ATOM H11X HAL2    0.09 !                  H11X---C311--H11Y
//  ATOM H11Y HAL2    0.09 !                         |
//  GROUP                  !
//  ATOM C312 CTL3   -0.27 !                         |
//  ATOM H12X HAL3    0.09 !                  H12X---C312--H12Y
//  ATOM H12Y HAL3    0.09 !                         |
//  ATOM H12Z HAL3    0.09 !                         H12Z
//   
//  ! Polar Head
//  BOND  N    HN1       N    HN2       N    HN3       N    C12
//  BOND  C12  H12A      C12  H12B      C12  C11
//  BOND  C11  H11A      C11  H11B      C11  O12
//  BOND  O12  P         P    O11       P    O13       P    O14
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        C1   O11
//  BOND  C2   HS        C2    C3       C2   O21
//  BOND  C3   HX        C3    HY       C3   O31
//  ! Chain #2
//  BOND  O21  C21
//  BOND  C21  C22
//  DOUBLE  C21  O22
//  BOND  C22  H2R       C22  H2S       C22  C23
//  BOND  C23  H3R       C23  H3S       C23  C24
//  BOND  C24  H4R       C24  H4S       C24  C25
//  BOND  C25  H5R       C25  H5S       C25  C26
//  BOND  C26  H6R       C26  H6S       C26  C27
//  BOND  C27  H7R       C27  H7S       C27  C28
//  BOND  C28  H8R       C28  H8S       C28  C29
//  BOND  C29  H9R       C29  H9S       C29  C210
//  BOND  C210 H10R      C210 H10S      C210 C211
//  BOND  C211 H11R      C211 H11S      C211 C212
//  BOND  C212 H12R      C212 H12S      C212 H12T
//  ! Chain #3
//  BOND  O31  C31
//  BOND  C31  C32
//  DOUBLE  C31  O32
//  BOND  C32  H2X       C32  H2Y       C32  C33
//  BOND  C33  H3X       C33  H3Y       C33  C34
//  BOND  C34  H4X       C34  H4Y       C34  C35
//  BOND  C35  H5X       C35  H5Y       C35  C36
//  BOND  C36  H6X       C36  H6Y       C36  C37
//  BOND  C37  H7X       C37  H7Y       C37  C38
//  BOND  C38  H8X       C38  H8Y       C38  C39
//  BOND  C39  H9X       C39  H9Y       C39  C310
//  BOND  C310 H10X      C310 H10Y      C310 C311
//  BOND  C311 H11X      C311 H11Y      C311 C312
//  BOND  C312 H12X      C312 H12Y      C312 H12Z
//  
//  IMPR C21 O21 C22 O22    C31 O31 C32 O32 
//  ! Polar head (angle names from Sundaralingam)
//  IC       C2    C1    O11   P      0.0  0.0  180.0  0.0  0.0 !alpha1
//  IC       C1    O11   P     O12    0.0  0.0  180.0  0.0  0.0 !alpha2
//  IC       O11   O12  *P     O13    0.0  0.0  120.0  0.0  0.0
//  IC       O11   O12  *P     O14    0.0  0.0  240.0  0.0  0.0
//  IC       O11   P     O12   C11    0.0  0.0  180.0  0.0  0.0 !alpha3
//  IC       O12   C12  *C11   H11A   0.0  0.0  120.0  0.0  0.0
//  IC       O12   C12  *C11   H11B   0.0  0.0  240.0  0.0  0.0
//  IC       P     O12   C11   C12    0.0  0.0  180.0  0.0  0.0 !alpha4
//  IC       N     C11  *C12   H12A   0.0  0.0  120.0  0.0  0.0
//  IC       N     C11  *C12   H12B   0.0  0.0  240.0  0.0  0.0
//  IC       O12   C11   C12   N      0.0  0.0  180.0  0.0  0.0 !alpha5
//  IC       C11   C12   N     HN1    0.0  0.0  180.0  0.0  0.0 !alpha6
//  IC       C12   HN1  *N     HN2    0.0  0.0  120.0  0.0  0.0
//  IC       C12   HN1  *N     HN3    0.0  0.0  240.0  0.0  0.0
//  ! Glycerol
//  IC       O11   C1    C2    C3     0.0  0.0  120.0  0.0  0.0 !theta1
//  IC       C1    C2    C3    O31    0.0  0.0  180.0  0.0  0.0 !theta3
//  IC       C1    C3   *C2    O21    0.0  0.0 -120.0  0.0  0.0
//  ! for stereo-specific phopholipid at carbon C2 (labeled hydrogen S)
//  IC       O11   C2   *C1    HA     0.0  0.0 +120.0  0.0  0.0
//  IC       O11   C2   *C1    HB     0.0  0.0 -120.0  0.0  0.0
//  IC       O21   C1   *C2    HS     0.0  0.0 +120.0  0.0  0.0
//  IC       O31   C2   *C3    HX     0.0  0.0 +120.0  0.0  0.0
//  IC       O31   C2   *C3    HY     0.0  0.0 -120.0  0.0  0.0
//  ! Chain 1
//  IC       C1    C2    O21   C21    0.0  0.0  180.0  0.0  0.0 !beta1
//  IC       C2    O21   C21   C22    0.0  0.0  120.0  0.0  0.0 !beta2
//  IC       O21   C21   C22   C23    0.0  0.0  180.0  0.0  0.0 !beta3
//  IC       C22   O21  *C21   O22    0.0  0.0  180.0  0.0  0.0
//  IC       C21   C22   C23   C24    0.0  0.0  180.0  0.0  0.0 !beta4
//  IC       C22   C23   C24   C25    0.0  0.0  180.0  0.0  0.0 !beta5
//  IC       C23   C24   C25   C26    0.0  0.0  180.0  0.0  0.0 !beta6
//  IC       C24   C25   C26   C27    0.0  0.0  180.0  0.0  0.0 !beta7
//  IC       C25   C26   C27   C28    0.0  0.0  180.0  0.0  0.0 !beta8
//  IC       C26   C27   C28   C29    0.0  0.0  180.0  0.0  0.0 !beta9
//  IC       C27   C28   C29   C210   0.0  0.0  180.0  0.0  0.0 !beta10
//  IC       C28   C29   C210  C211   0.0  0.0  180.0  0.0  0.0 !beta11
//  IC       C29   C210  C211  C212   0.0  0.0  180.0  0.0  0.0 !beta12
//  ! Chain 2
//  IC       C2    C3    O31   C31    0.0  0.0 -120.0  0.0  0.0 !gamma1
//  IC       C3    O31   C31   C32    0.0  0.0  180.0  0.0  0.0 !gamma2
//  IC       O31   C31   C32   C33    0.0  0.0  180.0  0.0  0.0 !gamma3
//  IC       C32   O31  *C31   O32    0.0  0.0  180.0  0.0  0.0
//  IC       C31   C32   C33   C34    0.0  0.0  180.0  0.0  0.0 !gamma4
//  IC       C32   C33   C34   C35    0.0  0.0  180.0  0.0  0.0 !gamma5
//  IC       C33   C34   C35   C36    0.0  0.0  180.0  0.0  0.0 !gamma6
//  IC       C34   C35   C36   C37    0.0  0.0  180.0  0.0  0.0 !gamma7
//  IC       C35   C36   C37   C38    0.0  0.0  180.0  0.0  0.0 !gamma8
//  IC       C36   C37   C38   C39    0.0  0.0  180.0  0.0  0.0 !gamma9
//  IC       C37   C38   C39   C310   0.0  0.0  180.0  0.0  0.0 !gamma10
//  IC       C38   C39   C310  C311   0.0  0.0  180.0  0.0  0.0 !gamma11
//  IC       C39   C310  C311  C312   0.0  0.0  180.0  0.0  0.0 !gamma12
//  
//  RESI DMPC         0.00 ! 1,2 dimiristoyl-SN-glycero-3-Phosphorylcholine
//  !
//  !  R1 - CH2        
//  !       |          (angles and atom names from Sundaralingam)
//  !  R2 - CH
//  !       |
//  !       CH2 - PO4 - CH2 - CH2 - N(CH3)3
//  !
//  ! Polar Head and glycerol backbone
//  GROUP                 !          H15B
//  ATOM N    NTL   -0.60 !            |
//  ATOM C13  CTL5  -0.35 !      H15A-C15-H15C
//  ATOM H13A HL     0.25 !            | 
//  ATOM H13B HL     0.25 !    H13B    |    H14A
//  ATOM H13C HL     0.25 !      |     |     |
//  ATOM C14  CTL5  -0.35 !H13A-C13----N----C14-H14B     (+)
//  ATOM H14A HL     0.25 !      |     |     |
//  ATOM H14B HL     0.25 !    H13C    |    H14C
//  ATOM H14C HL     0.25 !            |
//  ATOM C15  CTL5  -0.35 !            |
//  ATOM H15A HL     0.25 !            |    alpha6
//  ATOM H15B HL     0.25 !            |  
//  ATOM H15C HL     0.25 !            |
//  ATOM C12  CTL2  -0.10 !     H12A--C12---H12B     
//  ATOM H12A HL     0.25 !            |
//  ATOM H12B HL     0.25 !            |    
//  GROUP                 !                  alpha5
//  ATOM C11  CTL2  -0.08 !            |
//  ATOM H11A HAL2   0.09 !     H11A--C11---H11B
//  ATOM H11B HAL2   0.09 !            |     alpha4
//  ATOM P    PL     1.50 !   (-) O13  O12
//  ATOM O13  O2L   -0.78 !         \ /      alpha3
//  ATOM O14  O2L   -0.78 !          P (+)
//  ATOM O11  OSL   -0.57 !         / \      alpha2
//  ATOM O12  OSL   -0.57 !   (-) O14  O11
//  ATOM C1   CTL2  -0.08 !            |     alpha1
//  ATOM HA   HAL2   0.09 !       HA---C1---HB
//  ATOM HB   HAL2   0.09 !            |     theta1
//  GROUP                 !            |
//  ATOM C2   CTL1   0.04 !       HS---C2- - - - - - -
//  ATOM HS   HAL1   0.09 !            | beta1        |
//  ATOM O21  OSL   -0.34 !       O22  O21          theta3
//  ATOM C21  CL     0.63 !        \\ /  beta2        |
//  ATOM O22  OBL   -0.52 !          C21
//  ATOM C22  CTL2  -0.08 !          |   beta3        |
//  ATOM H2R  HAL2   0.09 !   H2R---C22---H2S
//  ATOM H2S  HAL2   0.09 !          |                |
//  GROUP                 !              beta4
//  ATOM C3   CTL2  -0.05 !          |                |
//  ATOM HX   HAL2   0.09 !                      HX---C3---HY
//  ATOM HY   HAL2   0.09 !          |                |   gamma1
//  ATOM O31  OSL   -0.34 !                      O32  O31
//  ATOM C31  CL     0.63 !          |            \\ /    gamma2
//  ATOM O32  OBL   -0.52 !                         C31
//  ATOM C32  CTL2  -0.08 !          |              |     gamma3
//  ATOM H2X  HAL2   0.09 !                  H2X---C32---H2Y
//  ATOM H2Y  HAL2   0.09 !          |              |
//  GROUP                 !                               gamma4
//  ATOM C23  CTL2  -0.18 !          |              |
//  ATOM H3R  HAL2   0.09 !   H3R ---C23---H3S
//  ATOM H3S  HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C24  CTL2  -0.18 !          |
//  ATOM H4R  HAL2   0.09 !   H4R ---C24---H4S      |
//  ATOM H4S  HAL2   0.09 !          |
//  GROUP                 !
//  ATOM C25  CTL2  -0.18 !          |              |
//  ATOM H5R  HAL2   0.09 !   H5R ---C25---H5S
//  ATOM H5S  HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C26  CTL2  -0.18 !          |
//  ATOM H6R  HAL2   0.09 !   H6R ---C26---H6S      |
//  ATOM H6S  HAL2   0.09 !          |
//  GROUP                 !
//  ATOM C27  CTL2  -0.18 !          |              |
//  ATOM H7R  HAL2   0.09 !   H7R ---C27---H7S
//  ATOM H7S  HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C28  CTL2  -0.18 !          |
//  ATOM H8R  HAL2   0.09 !   H8R ---C28---H8S      |
//  ATOM H8S  HAL2   0.09 !          |
//  GROUP                 !
//  ATOM C29  CTL2  -0.18 !          |              |
//  ATOM H9R  HAL2   0.09 !   H9R ---C29---H9S
//  ATOM H9S  HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C210 CTL2  -0.18 !          |
//  ATOM H10R HAL2   0.09 !   H10R---C210--H10S     |
//  ATOM H10S HAL2   0.09 !          |
//  GROUP                 !
//  ATOM C211 CTL2  -0.18 !          |              |
//  ATOM H11R HAL2   0.09 !   H11R---C211--H11S
//  ATOM H11S HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C212 CTL2  -0.18 !          |
//  ATOM H12R HAL2   0.09 !   H12R---C212--H12S     |
//  ATOM H12S HAL2   0.09 !          |
//  GROUP                 !
//  ATOM C213 CTL2  -0.18 !          |              |
//  ATOM H13R HAL2   0.09 !   H13R---C213--H13S
//  ATOM H13S HAL2   0.09 !          |              |
//  GROUP                 !
//  ATOM C214 CTL3  -0.27 !          |
//  ATOM H14R HAL3   0.09 !   H14R---C214--H14S     |
//  ATOM H14S HAL3   0.09 !          |
//  ATOM H14T HAL3   0.09 !         H14T            |
//  GROUP                 !
//  ATOM C33  CTL2  -0.18 !                         |
//  ATOM H3X  HAL2   0.09 !                  H3X ---C33---H3Y
//  ATOM H3Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C34  CTL2  -0.18 !                         |
//  ATOM H4X  HAL2   0.09 !                  H4X ---C34---H4Y
//  ATOM H4Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C35  CTL2  -0.18 !                         |
//  ATOM H5X  HAL2   0.09 !                  H5X ---C35---H5Y
//  ATOM H5Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C36  CTL2  -0.18 !                         |
//  ATOM H6X  HAL2   0.09 !                  H6X ---C36---H6Y
//  ATOM H6Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C37  CTL2  -0.18 !                         |
//  ATOM H7X  HAL2   0.09 !                  H7X ---C37---H7Y
//  ATOM H7Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C38  CTL2  -0.18 !                         |
//  ATOM H8X  HAL2   0.09 !                  H8X ---C38---H8Y
//  ATOM H8Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C39  CTL2  -0.18 !                         |
//  ATOM H9X  HAL2   0.09 !                  H9X ---C39---H9Y
//  ATOM H9Y  HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C310 CTL2  -0.18 !                         |
//  ATOM H10X HAL2   0.09 !                  H10X---C310--H10Y
//  ATOM H10Y HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C311 CTL2  -0.18 !                         |
//  ATOM H11X HAL2   0.09 !                  H11X---C311--H11Y
//  ATOM H11Y HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C312 CTL2  -0.18 !                         |
//  ATOM H12X HAL2   0.09 !                  H12X---C312--H12Y
//  ATOM H12Y HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C313 CTL2  -0.18 !                         |
//  ATOM H13X HAL2   0.09 !                  H13X---C313--H13Y
//  ATOM H13Y HAL2   0.09 !                         |
//  GROUP                 !
//  ATOM C314 CTL3  -0.27 !                         |
//  ATOM H14X HAL3   0.09 !                  H14X---C314--H14Y
//  ATOM H14Y HAL3   0.09 !                         |
//  ATOM H14Z HAL3   0.09 !                         H14Z
//   
//  ! Polar Head
//  BOND  N    C13       N    C14       N    C15       
//  BOND  C13  H13A      C13  H13B      C13  H13C 
//  BOND  C14  H14A      C14  H14B      C14  H14C 
//  BOND  C15  H15A      C15  H15B      C15  H15C 
//  BOND  N    C12
//  BOND  C12  H12A      C12  H12B      C12  C11
//  BOND  C11  H11A      C11  H11B      C11  O12   
//  BOND  O12  P         P    O11       P    O13       P    O14 
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        C1   O11
//  BOND  C2   HS        C2    C3       C2   O21
//  BOND  C3   HX        C3    HY       C3   O31
//  ! Chain #2
//  BOND  O21  C21
//  BOND  C21  C22
//  DOUBLE C21  O22 
//  BOND  C22  H2R       C22  H2S       C22  C23
//  BOND  C23  H3R       C23  H3S       C23  C24
//  BOND  C24  H4R       C24  H4S       C24  C25
//  BOND  C25  H5R       C25  H5S       C25  C26
//  BOND  C26  H6R       C26  H6S       C26  C27
//  BOND  C27  H7R       C27  H7S       C27  C28
//  BOND  C28  H8R       C28  H8S       C28  C29
//  BOND  C29  H9R       C29  H9S       C29  C210
//  BOND  C210 H10R      C210 H10S      C210 C211
//  BOND  C211 H11R      C211 H11S      C211 C212
//  BOND  C212 H12R      C212 H12S      C212 C213
//  BOND  C213 H13R      C213 H13S      C213 C214
//  BOND  C214 H14R      C214 H14S      C214 H14T
//  ! Chain #3
//  BOND  O31  C31
//  BOND  C31  C32
//  DOUBLE  C31  O32
//  BOND  C32  H2X       C32  H2Y       C32  C33
//  BOND  C33  H3X       C33  H3Y       C33  C34
//  BOND  C34  H4X       C34  H4Y       C34  C35
//  BOND  C35  H5X       C35  H5Y       C35  C36
//  BOND  C36  H6X       C36  H6Y       C36  C37
//  BOND  C37  H7X       C37  H7Y       C37  C38
//  BOND  C38  H8X       C38  H8Y       C38  C39
//  BOND  C39  H9X       C39  H9Y       C39  C310
//  BOND  C310 H10X      C310 H10Y      C310 C311
//  BOND  C311 H11X      C311 H11Y      C311 C312
//  BOND  C312 H12X      C312 H12Y      C312 C313
//  BOND  C313 H13X      C313 H13Y      C313 C314
//  BOND  C314 H14X      C314 H14Y      C314 H14Z
//  
//  IMPR C21 O21 C22 O22   C31 O31 C32 O32
//  
//  ! Polar head (angle names from Sundaralingam)
//  IC       C2    C1    O11   P      0.0  0.0  180.0  0.0  0.0 !alpha1
//  IC       C1    O11   P     O12    0.0  0.0  180.0  0.0  0.0 !alpha2
//  IC       O11   O12  *P     O13    0.0  0.0  120.0  0.0  0.0
//  IC       O11   O12  *P     O14    0.0  0.0  240.0  0.0  0.0
//  IC       O11   P     O12   C11    0.0  0.0  180.0  0.0  0.0 !alpha3
//  IC       O12   C12  *C11   H11A   0.0  0.0  120.0  0.0  0.0
//  IC       O12   C12  *C11   H11B   0.0  0.0  240.0  0.0  0.0
//  IC       P     O12   C11   C12    0.0  0.0  180.0  0.0  0.0 !alpha4
//  IC       N     C11  *C12   H12A   0.0  0.0  120.0  0.0  0.0
//  IC       N     C11  *C12   H12B   0.0  0.0  240.0  0.0  0.0
//  IC       O12   C11   C12   N      0.0  0.0  180.0  0.0  0.0 !alpha5
//  IC       C11   C12   N     C13    0.0  0.0  180.0  0.0  0.0 !alpha6
//  IC       C12   C13  *N     C14    0.0  0.0  120.0  0.0  0.0
//  IC       C12   C13  *N     C15    0.0  0.0  240.0  0.0  0.0
//  
//  ! Glycerol
//  IC       O11   C1    C2    C3     0.0  0.0  120.0  0.0  0.0 !theta1
//  IC       C1    C2    C3    O31    0.0  0.0  180.0  0.0  0.0 !theta3
//  IC       C1    C3   *C2    O21    0.0  0.0 -120.0  0.0  0.0
//  ! for stereo-specific phopholipid at carbon C2 (labeled hydrogen S)
//  IC       O11   C2   *C1    HA     0.0  0.0 +120.0  0.0  0.0
//  IC       O11   C2   *C1    HB     0.0  0.0 -120.0  0.0  0.0
//  IC       O21   C1   *C2    HS     0.0  0.0 +120.0  0.0  0.0
//  IC       O31   C2   *C3    HX     0.0  0.0 +120.0  0.0  0.0
//  IC       O31   C2   *C3    HY     0.0  0.0 -120.0  0.0  0.0
//  ! Chain 1
//  IC       C1    C2    O21   C21    0.0  0.0  180.0  0.0  0.0 !beta1
//  IC       C2    O21   C21   C22    0.0  0.0  120.0  0.0  0.0 !beta2
//  IC       O21   C21   C22   C23    0.0  0.0  180.0  0.0  0.0 !beta3
//  IC       C22   O21  *C21   O22    0.0  0.0  180.0  0.0  0.0
//  IC       C21   C22   C23   C24    0.0  0.0  180.0  0.0  0.0 !beta4
//  IC       C22   C23   C24   C25    0.0  0.0  180.0  0.0  0.0 !beta5
//  IC       C23   C24   C25   C26    0.0  0.0  180.0  0.0  0.0 !beta6
//  IC       C24   C25   C26   C27    0.0  0.0  180.0  0.0  0.0 !beta7
//  IC       C25   C26   C27   C28    0.0  0.0  180.0  0.0  0.0 !beta8
//  IC       C26   C27   C28   C29    0.0  0.0  180.0  0.0  0.0 !beta9
//  IC       C27   C28   C29   C210   0.0  0.0  180.0  0.0  0.0 !beta10
//  IC       C28   C29   C210  C211   0.0  0.0  180.0  0.0  0.0 !beta11
//  IC       C29   C210  C211  C212   0.0  0.0  180.0  0.0  0.0 !beta12
//  IC       C210  C211  C212  C213   0.0  0.0  180.0  0.0  0.0 !beta13
//  IC       C211  C212  C213  C214   0.0  0.0  180.0  0.0  0.0 !beta14
//  ! Chain 2
//  IC       C2    C3    O31   C31    0.0  0.0 -120.0  0.0  0.0 !gamma1
//  IC       C3    O31   C31   C32    0.0  0.0  180.0  0.0  0.0 !gamma2
//  IC       O31   C31   C32   C33    0.0  0.0  180.0  0.0  0.0 !gamma3
//  IC       C32   O31  *C31   O32    0.0  0.0  180.0  0.0  0.0
//  IC       C31   C32   C33   C34    0.0  0.0  180.0  0.0  0.0 !gamma4
//  IC       C32   C33   C34   C35    0.0  0.0  180.0  0.0  0.0 !gamma5
//  IC       C33   C34   C35   C36    0.0  0.0  180.0  0.0  0.0 !gamma6
//  IC       C34   C35   C36   C37    0.0  0.0  180.0  0.0  0.0 !gamma7
//  IC       C35   C36   C37   C38    0.0  0.0  180.0  0.0  0.0 !gamma8
//  IC       C36   C37   C38   C39    0.0  0.0  180.0  0.0  0.0 !gamma9
//  IC       C37   C38   C39   C310   0.0  0.0  180.0  0.0  0.0 !gamma10
//  IC       C38   C39   C310  C311   0.0  0.0  180.0  0.0  0.0 !gamma11
//  IC       C39   C310  C311  C312   0.0  0.0  180.0  0.0  0.0 !gamma12
//  IC       C310  C311  C312  C313   0.0  0.0  180.0  0.0  0.0 !gamma13
//  IC       C311  C312  C313  C314   0.0  0.0  180.0  0.0  0.0 !gamma14
//   
//  RESI SDS         -1.00 ! Dodecylsulphate
//                         ! based on methylsulfate
//  GROUP
//  ATOM S    SL      1.33 !           OS2(-1)
//  ATOM OS1  OSL    -0.28 !             |
//  ATOM OS2  O2L    -0.65 !   (-) OS2--S(+2)--OS4 (-)
//  ATOM OS3  O2L    -0.65 !             |
//  ATOM OS4  O2L    -0.65 !            OS1
//  ATOM C1   CTL2   -0.28 !              \
//  ATOM H11  HAL2    0.09 !          H11-C1-H12
//  ATOM H12  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C2   CTL2   -0.18 !          H21-C2-H22
//  ATOM H21  HAL2    0.09 !               |
//  ATOM H22  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C3   CTL2   -0.18 !          H31-C3-H32
//  ATOM H31  HAL2    0.09 !               |
//  ATOM H32  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C4   CTL2   -0.18 !          H41-C4-H42
//  ATOM H41  HAL2    0.09 !               |
//  ATOM H42  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C5   CTL2   -0.18 !          H51-C5-H52
//  ATOM H51  HAL2    0.09 !               |
//  ATOM H52  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C6   CTL2   -0.18 !          H61-C6-H62
//  ATOM H61  HAL2    0.09 !               |
//  ATOM H62  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C7   CTL2   -0.18 !          H71-C7-H72
//  ATOM H71  HAL2    0.09 !               |
//  ATOM H72  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C8   CTL2   -0.18 !          H81-C8-H82
//  ATOM H81  HAL2    0.09 !               |
//  ATOM H82  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C9   CTL2   -0.18 !          H91-C9-H92
//  ATOM H91  HAL2    0.09 !               |
//  ATOM H92  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C10  CTL2   -0.18 !         H101-C10-H102
//  ATOM H101 HAL2    0.09 !               |
//  ATOM H102 HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C11  CTL2   -0.18 !         H111-C11-H112
//  ATOM H111 HAL2    0.09 !               |
//  ATOM H112 HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C12  CTL3   -0.27 !         H121-C12-H123
//  ATOM H121 HAL3    0.09 !               |
//  ATOM H122 HAL3    0.09 !             H122
//  ATOM H123 HAL3    0.09 !
//  
//  BOND  S   OS1 S   OS2  S   OS3  S  OS4 
//  BOND  OS1 C1  C1  H11  C1  H12  
//  BOND  C1  C2  C2  H21  C2  H22
//  BOND  C2  C3  C3  H31  C3  H32
//  BOND  C3  C4  C4  H41  C4  H42
//  BOND  C4  C5  C5  H51  C5  H52
//  BOND  C5  C6  C6  H61  C6  H62
//  BOND  C6  C7  C7  H71  C7  H72
//  BOND  C7  C8  C8  H81  C8  H82
//  BOND  C8  C9  C9  H91  C9  H92
//  BOND  C9  C10 C10 H101 C10 H102
//  BOND  C10 C11 C11 H111 C11 H112
//  BOND  C11 C12 C12 H121 C12 H122 C12 H123
//  
//  ACCE  OS1
//  ACCE  OS2
//  ACCE  OS3
//  ACCE  OS4
//  
//  IC C2   OS1  OS2  S    2.56     179.99      0.0      40.1      0.00
//  IC OS1  OS2  *S   OS3  2.37      40.1     120.0       0.00     0.00
//  IC OS1  OS2  *S   OS4  2.37      40.1    -120.0       0.00     0.00
//  IC OS2  S    OS1  C1   0.00       0.00    180.0       0.00     0.00
//  IC OS4  S    OS2  OS1  1.4530   113.50   -113.75     40.11     2.3733
//  IC OS2  S    OS2  OS3  1.4522     0.00      0.00     33.26     2.4296
//  IC OS3  S    OS1  OS4  1.4530   105.51    121.17     35.54     2.4088
//  IC OS1  S    OS3  OS2  1.5716   105.51    112.45     33.24     2.4296
//  IC C1   OS1  S    OS2  1.4263   114.59   -180.00    103.34     1.4522
//  IC S    OS1  C1   OS3  1.5716   114.59    -30.52     56.05     2.8947
//  IC OS1  S    OS4  OS2  1.5716   105.51   -112.45     33.24     2.4296
//  IC OS1  S    OS2  OS3  1.5716   103.34   -113.75     33.26     2.4296
//  IC OS1  S    OS3  OS2  1.5716   105.51    112.45     33.24     2.4296
//  IC OS4  S    OS2  OS1  1.4530   113.50   -113.75     40.11     2.3733
//  IC OS4  S    OS3  OS1  1.4530   114.15    115.37     38.95     2.4088
//  IC OS3  S    OS2  OS1  1.4530   113.50    113.75     40.11     2.3733
//  IC OS4  S    OS1  C1   1.4530   105.51    -60.58     114.59    1.4263
//  IC OS2  S    OS1  C1   1.4522   103.34   -180.00     114.59    1.4263
//  IC OS3  S    OS1  C1   1.4530   105.51     60.58     114.59    1.4263
//  ! REMAINDER IS ALL TRANS
//  IC S    OS1  C1   C2   0.0        0.00    180.00       0.0     0.0
//  IC OS1  C1   C2   C3   0.0        0.00    180.00       0.0     0.0
//  IC C1   C2   C3   C4   0.0        0.00    180.00       0.0     0.0
//  IC C2   C3   C4   C5   0.0        0.00    180.00       0.0     0.0
//  IC C3   C4   C5   C6   0.0        0.00    180.00       0.0     0.0
//  IC C4   C5   C6   C7   0.0        0.00    180.00       0.0     0.0
//  IC C5   C6   C7   C8   0.0        0.00    180.00       0.0     0.0
//  IC C6   C7   C8   C9   0.0        0.00    180.00       0.0     0.0
//  IC C7   C8   C9   C10  0.0        0.00    180.00       0.0     0.0
//  IC C8   C9   C10  C11  0.0        0.00    180.00       0.0     0.0
//  IC C9   C10  C11  C12  0.0        0.00    180.00       0.0     0.0
//  IC OS1  C2   *C1  H11  0.0        0.00    120.00       0.0     0.0
//  IC OS1  C2   *C1  H12  0.0        0.00   -120.00       0.0     0.0
//  IC C1   C3   *C2  H21  0.0        0.00    120.00       0.0     0.0
//  IC C1   C3   *C2  H22  0.0        0.00   -120.00       0.0     0.0
//  IC C2   C4   *C3  H31  0.0        0.00    120.00       0.0     0.0
//  IC C2   C4   *C3  H32  0.0        0.00   -120.00       0.0     0.0
//  IC C3   C5   *C4  H41  0.0        0.00    120.00       0.0     0.0
//  IC C3   C5   *C4  H42  0.0        0.00   -120.00       0.0     0.0
//  IC C4   C6   *C5  H51  0.0        0.00    120.00       0.0     0.0
//  IC C4   C6   *C5  H52  0.0        0.00   -120.00       0.0     0.0
//  IC C5   C7   *C6  H61  0.0        0.00    120.00       0.0     0.0
//  IC C5   C7   *C6  H62  0.0        0.00   -120.00       0.0     0.0
//  IC C6   C8   *C7  H71  0.0        0.00    120.00       0.0     0.0
//  IC C6   C8   *C7  H72  0.0        0.00   -120.00       0.0     0.0
//  IC C7   C9   *C8  H81  0.0        0.00    120.00       0.0     0.0
//  IC C7   C9   *C8  H82  0.0        0.00   -120.00       0.0     0.0
//  IC C8   C10  *C9  H91  0.0        0.00    120.00       0.0     0.0
//  IC C8   C10  *C9  H92  0.0        0.00   -120.00       0.0     0.0
//  IC C9   C11  *C10 H101 0.0        0.00    120.00       0.0     0.0
//  IC C9   C11  *C10 H102 0.0        0.00   -120.00       0.0     0.0
//  IC C10  C12  *C11 H111 0.0        0.00    120.00       0.0     0.0
//  IC C10  C12  *C11 H112 0.0        0.00   -120.00       0.0     0.0
//  IC C10  C11  C12  H121 0.0        0.00    180.00       0.0     0.0
//  IC C11  H121 *C12 H122 0.0        0.00    120.00       0.0     0.0
//  IC C11  H121 *C12 H123 0.0        0.00   -120.00       0.0     0.0
//  
//  RESI POPC         0.00 ! 1-palmytoil-2-oleoyl-sn-glycero-
//  !                        3-Phosphatidylcholine
//  !
//  ! (May 14, 1999 Carlos F. Lopez)
//  ! No IC's (read in coordinates from file)
//  !
//  !  Palmytoil - CH2        
//  !              |  
//  !      Oleyl - CH
//  !              |     (-)              (+)
//  !              CH2 - PO4 - CH2 - CH2 - N-(CH3)3
//  !
//  ! Polar Head and glycerol backbone
//  GROUP                  !                 H31
//  ATOM N    NTL    -0.60 !                 |
//  ATOM C11  CTL2   -0.10 !             H33-C13-H32
//  ATOM C12  CTL5   -0.35 !                 |
//  ATOM C13  CTL5   -0.35 !           H21   |   H43
//  ATOM C14  CTL5   -0.35 !            |    |   |
//  ATOM H11  HL      0.25 !       H22-C12---N---C14-H42   (+)
//  ATOM H12  HL      0.25 !            |    |   |
//  ATOM H21  HL      0.25 !            H23  |   H41
//  ATOM H22  HL      0.25 !                 |
//  ATOM H23  HL      0.25 !                 |
//  ATOM H31  HL      0.25 !                 |
//  ATOM H32  HL      0.25 !             H11-C11-H12
//  ATOM H33  HL      0.25 !                 |
//  ATOM H41  HL      0.25 !                 |
//  ATOM H42  HL      0.25 !                 |
//  ATOM H43  HL      0.25 !                 |
//  GROUP                  !                 |
//  ATOM C15  CTL2   -0.08 !                 |
//  ATOM H51  HAL2    0.09 !           H51---C15---H52
//  ATOM H52  HAL2    0.09 !                 |
//  GROUP                  !                 |
//  ATOM P1   PL      1.50 !       (-) O3   O1
//  ATOM O3   O2L    -0.78 !             \ /
//  ATOM O4   O2L    -0.78 !              P1 (+)
//  ATOM O1   OSL    -0.57 !             / \
//  ATOM O2   OSL    -0.57 !       (-) O4   O2
//  GROUP                  !                 |
//  ATOM C1   CTL2   -0.08 !                 |     alpha1
//  ATOM HA   HAL2    0.09 !            HA---C1---HB
//  ATOM HB   HAL2    0.09 !                 |     theta1
//  GROUP                  !                 |
//  ATOM C2   CTL1    0.04 !            HS---C2--------------
//  ATOM HS   HAL1    0.09 !                 | beta1        |
//  ATOM O21  OSL    -0.34 !            O22  O21          theta3
//  ATOM C21  CL      0.63 !             \\ /  beta2        |
//  ATOM O22  OBL    -0.52 !               C21              |
//  ATOM C22  CTL2   -0.08 !               |   beta3        |
//  ATOM H2R  HAL2    0.09 !        H2R---C22---H2S         |
//  ATOM H2S  HAL2    0.09 !               |                |
//  GROUP                  !               |    beta4       |
//  ATOM C3   CTL2   -0.05 !               |                |
//  ATOM HX   HAL2    0.09 !               |           HX---C3---HY
//  ATOM HY   HAL2    0.09 !               |                |   gamma1
//  ATOM O31  OSL    -0.34 !               |           O32  O31
//  ATOM C31  CL      0.63 !               |            \\ /    gamma2
//  ATOM O32  OBL    -0.52 !               |              C31
//  ATOM C32  CTL2   -0.08 !               |              |     gamma3
//  ATOM H2X  HAL2    0.09 !               |        H2X---C32---H2Y
//  ATOM H2Y  HAL2    0.09 !               |              |
//  GROUP                  !               |              |      gamma4
//  ATOM C23  CTL2   -0.18 !               |              |
//  ATOM H3R  HAL2    0.09 !        H3R ---C23---H3S      |
//  ATOM H3S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C24  CTL2   -0.18 !               |              |
//  ATOM H4R  HAL2    0.09 !        H4R ---C24---H4S      |
//  ATOM H4S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C25  CTL2   -0.18 !               |              |
//  ATOM H5R  HAL2    0.09 !        H5R ---C25---H5S      |
//  ATOM H5S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C26  CTL2   -0.18 !               |              |
//  ATOM H6R  HAL2    0.09 !        H6R ---C26---H6S      |
//  ATOM H6S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C27  CTL2   -0.18 !               |              |
//  ATOM H7R  HAL2    0.09 !        H7R ---C27---H7S      |
//  ATOM H7S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C28  CTL2   -0.18 !               |              |
//  ATOM H8R  HAL2    0.09 !        H8R ---C28---H8S      |
//  ATOM H8S  HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C29  CEL1   -0.15 !               |              |
//  ATOM H91  HEL1    0.15 !        H91 ---C29            |
//  GROUP                  !               ||  (CIS)      |
//  ATOM C210 CEL1   -0.15 !               ||             |
//  ATOM H101 HEL1    0.15 !        H101---C210           |
//  GROUP                  !               |              |
//  ATOM C211 CTL2   -0.18 !               |              |
//  ATOM H11R HAL2    0.09 !        H11R---C211--H11S     |
//  ATOM H11S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C212 CTL2   -0.18 !               |              |
//  ATOM H12R HAL2    0.09 !        H12R---C212--H12S     |
//  ATOM H12S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C213 CTL2   -0.18 !               |              |
//  ATOM H13R HAL2    0.09 !        H13R---C213--H13S     |
//  ATOM H13S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C214 CTL2   -0.18 !               |              |
//  ATOM H14R HAL2    0.09 !        H14R---C214--H14S     |
//  ATOM H14S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C215 CTL2   -0.18 !               |              |
//  ATOM H15R HAL2    0.09 !        H15R---C215--H15S     |
//  ATOM H15S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C216 CTL2   -0.18 !               |              |
//  ATOM H16R HAL2    0.09 !        H16R---C216--H16S     |
//  ATOM H16S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C217 CTL2   -0.18 !               |              |
//  ATOM H17R HAL2    0.09 !        H17R---C217--H17S     |
//  ATOM H17S HAL2    0.09 !               |              |
//  GROUP                  !               |              |
//  ATOM C218 CTL3   -0.27 !               |              |
//  ATOM H18R HAL3    0.09 !        H18R---C218--H18S     |
//  ATOM H18S HAL3    0.09 !               |              |
//  ATOM H18T HAL3    0.09 !              H18T            |
//  GROUP                  !                              |
//  ATOM C33  CTL2   -0.18 !                              |
//  ATOM H3X  HAL2    0.09 !                       H3X ---C33---H3Y
//  ATOM H3Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C34  CTL2   -0.18 !                              |
//  ATOM H4X  HAL2    0.09 !                       H4X ---C34---H4Y
//  ATOM H4Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C35  CTL2   -0.18 !                              |
//  ATOM H5X  HAL2    0.09 !                       H5X ---C35---H5Y
//  ATOM H5Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C36  CTL2   -0.18 !                              |
//  ATOM H6X  HAL2    0.09 !                       H6X ---C36---H6Y
//  ATOM H6Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C37  CTL2   -0.18 !                              |
//  ATOM H7X  HAL2    0.09 !                       H7X ---C37---H7Y
//  ATOM H7Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C38  CTL2   -0.18 !                              |
//  ATOM H8X  HAL2    0.09 !                       H8X ---C38---H8Y
//  ATOM H8Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C39  CTL2   -0.18 !                              |
//  ATOM H9X  HAL2    0.09 !                       H9X ---C39---H9Y
//  ATOM H9Y  HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C310 CTL2   -0.18 !                              |
//  ATOM H10X HAL2    0.09 !                       H10X---C310--H10Y
//  ATOM H10Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C311 CTL2   -0.18 !                              |
//  ATOM H11X HAL2    0.09 !                       H11X---C311--H11Y
//  ATOM H11Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C312 CTL2   -0.18 !                              |
//  ATOM H12X HAL2    0.09 !                       H12X---C312--H12Y
//  ATOM H12Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C313 CTL2   -0.18 !                              |
//  ATOM H13X HAL2    0.09 !                       H13X---C313--H13Y
//  ATOM H13Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C314 CTL2   -0.18 !                              |
//  ATOM H14X HAL2    0.09 !                       H14X---C314--H14Y
//  ATOM H14Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C315 CTL2   -0.18 !                              |
//  ATOM H15X HAL2    0.09 !                       H15X---C315--H15Y
//  ATOM H15Y HAL2    0.09 !                              |
//  GROUP                  !                              |
//  ATOM C316 CTL3   -0.27 !                              |
//  ATOM H16X HAL3    0.09 !                       H16X---C316--H16Y
//  ATOM H16Y HAL3    0.09 !                              |
//  ATOM H16Z HAL3    0.09 !                              H16Z
//   
//  !BONDING FROM PC
//  BOND N     C11       N     C12      N     C13     N     C14
//  BOND C11   H11       C11   H12      C11   C15
//  BOND C12   H21       C12   H22      C12   H23
//  BOND C13   H31       C13   H32      C13   H33
//  BOND C14   H41       C14   H42      C14   H43
//  BOND C15   H51       C15   H52
//  BOND P1    O1        P1    O2       P1    O3      P1    O4    
//  BOND O1    C15       O2    C1
//  
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        
//  BOND  C2   HS        C2    C3       C2   O21
//  BOND  C3   HX        C3    HY       C3   O31
//  ! Chain from C2
//  BOND  O21  C21
//  BOND  C21  C22
//  DOUBLE  C21  O22
//  BOND  C22  H2R       C22  H2S       C22  C23
//  BOND  C23  H3R       C23  H3S       C23  C24
//  BOND  C24  H4R       C24  H4S       C24  C25
//  BOND  C25  H5R       C25  H5S       C25  C26
//  BOND  C26  H6R       C26  H6S       C26  C27
//  BOND  C27  H7R       C27  H7S       C27  C28
//  BOND  C28  H8R       C28  H8S       C28  C29
//  BOND  C29  H91       
//  DOUBLE  C29 C210
//  BOND  C210 H101      C210 C211
//  BOND  C211 H11R      C211 H11S      C211 C212
//  BOND  C212 H12R      C212 H12S      C212 C213
//  BOND  C213 H13R      C213 H13S      C213 C214
//  BOND  C214 H14R      C214 H14S      C214 C215
//  BOND  C215 H15R      C215 H15S      C215 C216
//  BOND  C216 H16R      C216 H16S      C216 C217
//  BOND  C217 H17R      C217 H17S      C217 C218
//  BOND  C218 H18R      C218 H18S      C218 H18T
//  ! Chain From C3
//  BOND  O31  C31
//  BOND  C31  C32
//  DOUBLE  C31  O32
//  BOND  C32  H2X       C32  H2Y       C32  C33
//  BOND  C33  H3X       C33  H3Y       C33  C34
//  BOND  C34  H4X       C34  H4Y       C34  C35
//  BOND  C35  H5X       C35  H5Y       C35  C36
//  BOND  C36  H6X       C36  H6Y       C36  C37
//  BOND  C37  H7X       C37  H7Y       C37  C38
//  BOND  C38  H8X       C38  H8Y       C38  C39
//  BOND  C39  H9X       C39  H9Y       C39  C310
//  BOND  C310 H10X      C310 H10Y      C310 C311
//  BOND  C311 H11X      C311 H11Y      C311 C312
//  BOND  C312 H12X      C312 H12Y      C312 C313
//  BOND  C313 H13X      C313 H13Y      C313 C314
//  BOND  C314 H14X      C314 H14Y      C314 C315
//  BOND  C315 H15X      C315 H15Y      C315 C316
//  BOND  C316 H16X      C316 H16Y      C316 H16Z
//  
//  IMPR C21 O21 C22 O22    C31 O31 C32 O32
//  
//  !IC table from IC generate, geometry is guessed
//  IC C12  C11  *N   C13  1.4999  109.15  122.15  111.71   1.4949
//  IC C12  C11  *N   C14  1.4999  109.15 -116.51  109.19   1.5011
//  IC C12  N    C11  C15  1.4999  109.15   43.57  118.04   1.5524
//  IC C15  N    *C11 H11  1.5524  118.04 -121.93  109.13   1.0811
//  IC H11  N    *C11 H12  1.0811  109.13 -117.56  108.83   1.0835
//  IC C11  N    C12  H21  1.5284  109.15  -59.57  108.41   1.0953
//  IC H21  N    *C12 H22  1.0953  108.41 -116.60  113.14   1.0854
//  IC H21  N    *C12 H23  1.0953  108.41  118.64  112.84   1.0777
//  IC C11  N    C13  H31  1.5284  111.71  -61.34  110.98   1.0826
//  IC H31  N    *C13 H32  1.0826  110.98  121.24  110.98   1.0826
//  IC H31  N    *C13 H33  1.0826  110.98 -119.19  110.09   1.0845
//  IC C11  N    C14  H41  1.5284  109.19  173.62  112.23   1.0785
//  IC H41  N    *C14 H42  1.0785  112.23  125.69  112.79   1.0778
//  IC H41  N    *C14 H43  1.0785  112.23 -117.12  108.08   1.0983
//  IC N    C11  C15  O1   1.5284  118.04   63.61  111.07   1.4249
//  IC O1   C11  *C15 H51  1.4249  111.07 -126.47  109.40   1.1165
//  IC H51  C11  *C15 H52  1.1165  109.40 -115.09  108.53   1.1137
//  IC C11  C15  O1   P1   1.5524  111.07 -132.50  121.66   1.5873
//  IC C15  O1   P1   O2   1.4249  121.66   95.32   99.37   1.5870
//  IC O2   O1   *P1  O3   1.5870   99.37 -113.40  108.96   1.4773
//  IC O2   O1   *P1  O4   1.5870   99.37  114.27  109.52   1.4735
//  IC O1   P1   O2   C1   1.5873   99.37 -136.11  119.34   1.4276
//  IC P1   O2   C1   C2   1.5870  119.34 -174.88  109.28   1.5468
//  IC C2   O2   *C1  HA   1.5468  109.28  119.70  111.34   1.1169
//  IC HA   O2   *C1  HB   1.1169  111.34  119.72  110.33   1.1141
//  IC O2   C1   C2   O21  1.4276  109.28 -167.70  109.50   1.4378
//  IC O21  C1   *C2  C3   1.4378  109.50 -121.42  111.45   1.5543
//  IC C3   C1   *C2  HS   1.5543  111.45 -117.17  108.32   1.1156
//  IC C1   C2   O21  C21  1.5468  109.50   90.28  116.64   1.3217
//  IC C2   O21  C21  C22  1.4378  116.64  174.47  109.18   1.5303
//  IC C22  O21  *C21 O22  1.5303  109.18 -178.13  126.27   1.2213
//  IC O21  C21  C22  C23  1.3217  109.18  -78.33  110.83   1.5447
//  IC C23  C21  *C22 H2R  1.5447  110.83  121.63  109.32   1.1103
//  IC H2R  C21  *C22 H2S  1.1103  109.32  117.81  107.94   1.1092
//  IC C1   C2   C3   O31  1.5468  111.45 -172.66  111.94   1.4454
//  IC O31  C2   *C3  HX   1.4454  111.94 -126.15  109.39   1.1150
//  IC HX   C2   *C3  HY   1.1150  109.39 -114.93  107.39   1.1133
//  IC C2   C3   O31  C31  1.5543  111.94  -96.66  116.55   1.3325
//  IC C3   O31  C31  C32  1.4454  116.55  177.97  109.29   1.5306
//  IC C32  O31  *C31 O32  1.5306  109.29 -179.43  126.40   1.2162
//  IC O31  C31  C32  C33  1.3325  109.29 -177.61  111.07   1.5445
//  IC C33  C31  *C32 H2X  1.5445  111.07  120.97  108.77   1.1094
//  IC H2X  C31  *C32 H2Y  1.1094  108.77  118.39  108.38   1.1099
//  IC C21  C22  C23  C24  1.5303  110.83  177.84  113.15   1.5345
//  IC C24  C22  *C23 H3R  1.5345  113.15 -120.52  109.51   1.1149
//  IC H3R  C22  *C23 H3S  1.1149  109.51 -117.98  109.32   1.1137
//  IC C22  C23  C24  C25  1.5447  113.15  174.44  112.06   1.5345
//  IC C25  C23  *C24 H4R  1.5345  112.06  121.05  109.09   1.1140
//  IC H4R  C23  *C24 H4S  1.1140  109.09  117.86  109.72   1.1131
//  IC C23  C24  C25  C26  1.5345  112.06  175.38  112.95   1.5340
//  IC C26  C24  *C25 H5R  1.5340  112.95 -121.08  109.34   1.1131
//  IC H5R  C24  *C25 H5S  1.1131  109.34 -117.43  108.99   1.1132
//  IC C24  C25  C26  C27  1.5345  112.95  174.94  112.21   1.5351
//  IC C27  C25  *C26 H6R  1.5351  112.21  121.27  109.00   1.1134
//  IC H6R  C25  *C26 H6S  1.1134  109.00  117.60  109.50   1.1130
//  IC C25  C26  C27  C28  1.5340  112.21  175.67  112.60   1.5394
//  IC C28  C26  *C27 H7R  1.5394  112.60 -121.40  108.58   1.1142
//  IC H7R  C26  *C27 H7S  1.1142  108.58 -116.93  108.44   1.1140
//  IC C26  C27  C28  C29  1.5351  112.60  178.25  111.01   1.5083
//  IC C29  C27  *C28 H8R  1.5083  111.01  119.62  107.18   1.1139
//  IC H8R  C27  *C28 H8S  1.1139  107.18  115.86  109.35   1.1118
//  IC C27  C28  C29  C210 1.5391  111.34 -141.40  127.31   1.3462
//  IC C210 C28  *C29 H91  1.3462  127.31 -176.71  114.35   1.1001
//  IC C28  C29  C210 C211 1.5073  127.31    1.24  127.43   1.5089
//  IC C211 C29  *C21 H101 1.5089  127.43  179.21  118.33   1.1011
//  IC C29  C210 C211 C212 1.3462  127.43 -120.91  110.88   1.5393
//  IC C212 C210 *C21 H11R 1.5393  110.88  121.06  112.51   1.1124
//  IC H11R C210 *C21 H11S 1.1124  112.51  119.00  109.81   1.1127
//  IC C210 C211 C212 C213 1.5089  110.88 -176.36  112.76   1.5347
//  IC C213 C211 *C21 H12R 1.5347  112.76 -120.93  109.33   1.1142
//  IC H12R C211 *C21 H12S 1.1142  109.33 -118.17  109.94   1.1138
//  IC C211 C212 C213 C214 1.5393  112.76 -179.47  112.21   1.5338
//  IC C214 C212 *C21 H13R 1.5338  112.21  121.29  109.31   1.1130
//  IC H13R C212 *C21 H13S 1.1130  109.31  117.74  109.05   1.1131
//  IC C212 C213 C214 C215 1.5347  112.21 -178.99  112.92   1.5339
//  IC C215 C213 *C21 H14R 1.5339  112.92 -121.37  109.00   1.1134
//  IC H14R C213 *C21 H14S 1.1134  109.00 -117.34  109.08   1.1132
//  IC C213 C214 C215 C216 1.5338  112.92  179.95  112.20   1.5339
//  IC C216 C214 *C21 H15R 1.5339  112.20  121.17  109.14   1.1131
//  IC H15R C214 *C21 H15S 1.1131  109.14  117.63  109.22   1.1132
//  IC C214 C215 C216 C217 1.5339  112.20  179.53  112.96   1.5328
//  IC C217 C215 *C21 H16R 1.5328  112.96 -121.41  109.07   1.1135
//  IC H16R C215 *C21 H16S 1.1135  109.07 -117.43  109.05   1.1130
//  IC C215 C216 C217 C218 1.5339  112.96 -179.21  113.03   1.5305
//  IC C218 C216 *C21 H17R 1.5305  113.03  121.55  108.80   1.1140
//  IC H17R C216 *C21 H17S 1.1140  108.80  116.88  108.83   1.1142
//  IC C216 C217 C218 H18R 1.5328  113.03   60.41  110.37   1.1113
//  IC H18R C217 *C21 H18S 1.1113  110.37 -119.78  110.49   1.1115
//  IC H18R C217 *C21 H18T 1.1113  110.37  120.07  110.59   1.1111
//  IC C31  C32  C33  C34  1.5333  111.40  179.66  112.54   1.5345
//  IC C34  C32  *C33 H3X  1.5345  112.54 -121.73  109.66   1.1133
//  IC H3X  C32  *C33 H3Y  1.1133  109.66 -117.45  109.37   1.1151
//  IC C32  C33  C34  C35  1.5440  112.54  178.40  112.54   1.5346
//  IC C35  C33  *C34 H4X  1.5346  112.54  121.75  110.03   1.1131
//  IC H4X  C33  *C34 H4Y  1.1131  110.03  117.75  108.84   1.1139
//  IC C33  C34  C35  C36  1.5345  112.54 -175.14  112.09   1.5349
//  IC C36  C34  *C35 H5X  1.5349  112.09 -122.26  109.27   1.1127
//  IC H5X  C34  *C35 H5Y  1.1127  109.27 -117.42  109.08   1.1138
//  IC C34  C35  C36  C37  1.5346  112.09  174.19  113.84   1.5368
//  IC C37  C35  *C36 H6X  1.5368  113.84  122.38  109.13   1.1124
//  IC H6X  C35  *C36 H6Y  1.1124  109.13  117.02  108.50   1.1143
//  IC C35  C36  C37  C38  1.5349  113.84   65.26  113.87   1.5343
//  IC C38  C36  *C37 H7X  1.5343  113.87  120.83  108.55   1.1137
//  IC H7X  C36  *C37 H7Y  1.1137  108.55  116.91  109.10   1.1132
//  IC C36  C37  C38  C39  1.5368  113.87  178.14  112.45   1.5354
//  IC C39  C37  *C38 H8X  1.5354  112.45  121.43  109.97   1.1123
//  IC H8X  C37  *C38 H8Y  1.1123  109.97  117.71  108.91   1.1127
//  IC C37  C38  C39  C310 1.5343  112.45 -176.66  111.96   1.5320
//  IC C310 C38  *C39 H9X  1.5320  111.96  120.68  109.20   1.1133
//  IC H9X  C38  *C39 H9Y  1.1133  109.20  117.81  109.34   1.1127
//  IC C38  C39  C310 C311 1.5354  111.96  178.35  113.81   1.5336
//  IC C311 C39  *C31 H10X 1.5336  113.81 -120.14  108.22   1.1126
//  IC H10X C39  *C31 H10Y 1.1126  108.22 -117.07  109.45   1.1132
//  IC C39  C310 C311 C312 1.5320  113.81 -175.46  111.16   1.5334
//  IC C312 C310 *C31 H11X 1.5334  111.16  120.27  109.12   1.1138
//  IC H11X C310 *C31 H11Y 1.1138  109.12  118.20  110.02   1.1119
//  IC C310 C311 C312 C313 1.5336  111.16  173.60  113.47   1.5330
//  IC C313 C311 *C31 H12X 1.5330  113.47 -120.74  108.01   1.1140
//  IC H12X C311 *C31 H12Y 1.1140  108.01 -116.85  109.45   1.1130
//  IC C311 C312 C313 C314 1.5334  113.47 -174.75  111.86   1.5335
//  IC C314 C312 *C31 H13X 1.5335  111.86  120.28  108.66   1.1135
//  IC H13X C312 *C31 H13Y 1.1135  108.66  118.03  110.08   1.1125
//  IC C312 C313 C314 C315 1.5330  111.86  175.21  113.05   1.5325
//  IC C315 C313 *C31 H14X 1.5325  113.05 -120.81  108.37   1.1133
//  IC H14X C313 *C31 H14Y 1.1133  108.37 -117.18  109.40   1.1131
//  IC C313 C314 C315 C316 1.5335  113.05 -177.76  112.89   1.5300
//  IC C316 C314 *C31 H15X 1.5300  112.89  121.41  108.55   1.1149
//  IC H15X C314 *C31 H15Y 1.1149  108.55  117.05  109.21   1.1136
//  IC C314 C315 C316 H16X 1.5325  112.89   57.15  110.07   1.1113
//  IC H16X C315 *C31 H16Y 1.1113  110.07 -119.27  110.55   1.1106
//  IC H16X C315 *C31 H16Z 1.1113  110.07  120.81  110.70   1.1116
//  
//  RESI POPE         0.00 ! 1-palmytoil-2-oleoyl-sn-glycero-
//  !                        3-Phosphatidylethanolamine
//  !
//  ! (May 14, 1999 Carlos F. Lopez)
//  !
//  !  Palmytoil - CH2        
//  !              |  
//  !      Oleyl - CH
//  !              |
//  !              CH2 - PO4 - CH2 - CH2 - NH3
//  !
//  ! Polar Head and glycerol backbone
//  GROUP                  !
//  ATOM N     NH3L  -0.30 !           HN2
//  ATOM HN1   HCL    0.33 !            |
//  ATOM HN2   HCL    0.33 !  (+) HN1---N---HN3
//  ATOM HN3   HCL    0.33 !            |
//  ATOM C12   CTL2   0.13 !            |
//  ATOM H12A  HAL2   0.09 !     H12A--C12---H12B
//  ATOM H12B  HAL2   0.09 !            |
//  GROUP                  !            |     alpha5
//  ATOM C11  CTL2   -0.08 !            |
//  ATOM H11A HAL2    0.09 !     H11A--C11---H11B
//  ATOM H11B HAL2    0.09 !            |     alpha4
//  ATOM P    PL      1.50 !   (-) O13  O12
//  ATOM O13  O2L    -0.78 !         \ /      alpha3
//  ATOM O14  O2L    -0.78 !          P (+)
//  ATOM O11  OSL    -0.57 !         / \      alpha2
//  ATOM O12  OSL    -0.57 !   (-) O14  O11
//  ATOM C1   CTL2   -0.08 !            |     alpha1
//  ATOM HA   HAL2    0.09 !       HA---C1---HB
//  ATOM HB   HAL2    0.09 !            |     theta1
//  GROUP                  !            |
//  ATOM C2   CTL1    0.04 !       HS---C2--------------
//  ATOM HS   HAL1    0.09 !            | beta1        |
//  ATOM O21  OSL    -0.34 !       O22  O21          theta3
//  ATOM C21  CL      0.63 !        \\ /  beta2        |
//  ATOM O22  OBL    -0.52 !          C21              |
//  ATOM C22  CTL2   -0.08 !          |   beta3        |
//  ATOM H2R  HAL2    0.09 !   H2R---C22---H2S         |
//  ATOM H2S  HAL2    0.09 !          |                |
//  GROUP                  !          |    beta4       |
//  ATOM C3   CTL2   -0.05 !          |                |
//  ATOM HX   HAL2    0.09 !          |           HX---C3---HY
//  ATOM HY   HAL2    0.09 !          |                |   gamma1
//  ATOM O31  OSL    -0.34 !          |           O32  O31
//  ATOM C31  CL      0.63 !          |            \\ /    gamma2
//  ATOM O32  OBL    -0.52 !          |              C31
//  ATOM C32  CTL2   -0.08 !          |              |     gamma3
//  ATOM H2X  HAL2    0.09 !          |        H2X---C32---H2Y
//  ATOM H2Y  HAL2    0.09 !          |              |
//  GROUP                  !          |              |      gamma4
//  ATOM C23  CTL2   -0.18 !          |              |
//  ATOM H3R  HAL2    0.09 !   H3R ---C23---H3S      |
//  ATOM H3S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C24  CTL2   -0.18 !          |              |
//  ATOM H4R  HAL2    0.09 !   H4R ---C24---H4S      |
//  ATOM H4S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C25  CTL2   -0.18 !          |              |
//  ATOM H5R  HAL2    0.09 !   H5R ---C25---H5S      |
//  ATOM H5S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C26  CTL2   -0.18 !          |              |
//  ATOM H6R  HAL2    0.09 !   H6R ---C26---H6S      |
//  ATOM H6S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C27  CTL2   -0.18 !          |              |
//  ATOM H7R  HAL2    0.09 !   H7R ---C27---H7S      |
//  ATOM H7S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C28  CTL2   -0.18 !          |              |
//  ATOM H8R  HAL2    0.09 !   H8R ---C28---H8S      |
//  ATOM H8S  HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C29  CEL1   -0.15 !          |              |
//  ATOM H91  HEL1    0.15 !   H91 ---C29            |
//  GROUP                  !          ||  (CIS)      |
//  ATOM C210 CEL1   -0.15 !          ||             |
//  ATOM H101 HEL1    0.15 !   H101---C210           |
//  GROUP                  !          |              |
//  ATOM C211 CTL2   -0.18 !          |              |
//  ATOM H11R HAL2    0.09 !   H11R---C211--H11S     |
//  ATOM H11S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C212 CTL2   -0.18 !          |              |
//  ATOM H12R HAL2    0.09 !   H12R---C212--H12S     |
//  ATOM H12S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C213 CTL2   -0.18 !          |              |
//  ATOM H13R HAL2    0.09 !   H13R---C213--H13S     |
//  ATOM H13S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C214 CTL2   -0.18 !          |              |
//  ATOM H14R HAL2    0.09 !   H14R---C214--H14S     |
//  ATOM H14S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C215 CTL2   -0.18 !          |              |
//  ATOM H15R HAL2    0.09 !   H15R---C215--H15S     |
//  ATOM H15S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C216 CTL2   -0.18 !          |              |
//  ATOM H16R HAL2    0.09 !   H16R---C216--H16S     |
//  ATOM H16S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C217 CTL2   -0.18 !          |              |
//  ATOM H17R HAL2    0.09 !   H17R---C217--H17S     |
//  ATOM H17S HAL2    0.09 !          |              |
//  GROUP                  !          |              |
//  ATOM C218 CTL3   -0.27 !          |              |
//  ATOM H18R HAL3    0.09 !   H18R---C218--H18S     |
//  ATOM H18S HAL3    0.09 !          |              |
//  ATOM H18T HAL3    0.09 !         H18T            |
//  GROUP                  !                         |
//  ATOM C33  CTL2   -0.18 !                         |
//  ATOM H3X  HAL2    0.09 !                  H3X ---C33---H3Y
//  ATOM H3Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C34  CTL2   -0.18 !                         |
//  ATOM H4X  HAL2    0.09 !                  H4X ---C34---H4Y
//  ATOM H4Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C35  CTL2   -0.18 !                         |
//  ATOM H5X  HAL2    0.09 !                  H5X ---C35---H5Y
//  ATOM H5Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C36  CTL2   -0.18 !                         |
//  ATOM H6X  HAL2    0.09 !                  H6X ---C36---H6Y
//  ATOM H6Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C37  CTL2   -0.18 !                         |
//  ATOM H7X  HAL2    0.09 !                  H7X ---C37---H7Y
//  ATOM H7Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C38  CTL2   -0.18 !                         |
//  ATOM H8X  HAL2    0.09 !                  H8X ---C38---H8Y
//  ATOM H8Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C39  CTL2   -0.18 !                         |
//  ATOM H9X  HAL2    0.09 !                  H9X ---C39---H9Y
//  ATOM H9Y  HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C310 CTL2   -0.18 !                         |
//  ATOM H10X HAL2    0.09 !                  H10X---C310--H10Y
//  ATOM H10Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C311 CTL2   -0.18 !                         |
//  ATOM H11X HAL2    0.09 !                  H11X---C311--H11Y
//  ATOM H11Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C312 CTL2   -0.18 !                         |
//  ATOM H12X HAL2    0.09 !                  H12X---C312--H12Y
//  ATOM H12Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C313 CTL2   -0.18 !                         |
//  ATOM H13X HAL2    0.09 !                  H13X---C313--H13Y
//  ATOM H13Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C314 CTL2   -0.18 !                         |
//  ATOM H14X HAL2    0.09 !                  H14X---C314--H14Y
//  ATOM H14Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C315 CTL2   -0.18 !                         |
//  ATOM H15X HAL2    0.09 !                  H15X---C315--H15Y
//  ATOM H15Y HAL2    0.09 !                         |
//  GROUP                  !                         |
//  ATOM C316 CTL3   -0.27 !                         |
//  ATOM H16X HAL3    0.09 !                  H16X---C316--H16Y
//  ATOM H16Y HAL3    0.09 !                         |
//  ATOM H16Z HAL3    0.09 !                         H16Z
//   
//  ! Polar Head
//  BOND  N    HN1       N    HN2       N    HN3       N    C12
//  BOND  C12  H12A      C12  H12B      C12  C11
//  BOND  C11  H11A      C11  H11B      C11  O12
//  BOND  O12  P         P    O11       P    O13       P    O14
//  ! Glycerol Backbone
//  BOND  C1   HA        C1    HB       C1   C2        C1   O11
//  BOND  C2   HS        C2    C3       C2   O21
//  BOND  C3   HX        C3    HY       C3   O31
//  ! Chain from C2
//  BOND  O21  C21
//  BOND  C21  C22
//  DOUBLE  C21  O22
//  BOND  C22  H2R       C22  H2S       C22  C23
//  BOND  C23  H3R       C23  H3S       C23  C24
//  BOND  C24  H4R       C24  H4S       C24  C25
//  BOND  C25  H5R       C25  H5S       C25  C26
//  BOND  C26  H6R       C26  H6S       C26  C27
//  BOND  C27  H7R       C27  H7S       C27  C28
//  BOND  C28  H8R       C28  H8S       C28  C29
//  BOND  C29  H91       
//  DOUBLE  C29 C210
//  BOND  C210 H101      C210 C211
//  BOND  C211 H11R      C211 H11S      C211 C212
//  BOND  C212 H12R      C212 H12S      C212 C213
//  BOND  C213 H13R      C213 H13S      C213 C214
//  BOND  C214 H14R      C214 H14S      C214 C215
//  BOND  C215 H15R      C215 H15S      C215 C216
//  BOND  C216 H16R      C216 H16S      C216 C217
//  BOND  C217 H17R      C217 H17S      C217 C218
//  BOND  C218 H18R      C218 H18S      C218 H18T
//  ! Chain From C3
//  BOND  O31  C31
//  BOND  C31  C32
//  DOUBLE  C31  O32
//  BOND  C32  H2X       C32  H2Y       C32  C33
//  BOND  C33  H3X       C33  H3Y       C33  C34
//  BOND  C34  H4X       C34  H4Y       C34  C35
//  BOND  C35  H5X       C35  H5Y       C35  C36
//  BOND  C36  H6X       C36  H6Y       C36  C37
//  BOND  C37  H7X       C37  H7Y       C37  C38
//  BOND  C38  H8X       C38  H8Y       C38  C39
//  BOND  C39  H9X       C39  H9Y       C39  C310
//  BOND  C310 H10X      C310 H10Y      C310 C311
//  BOND  C311 H11X      C311 H11Y      C311 C312
//  BOND  C312 H12X      C312 H12Y      C312 C313
//  BOND  C313 H13X      C313 H13Y      C313 C314
//  BOND  C314 H14X      C314 H14Y      C314 C315
//  BOND  C315 H15X      C315 H15Y      C315 C316
//  BOND  C316 H16X      C316 H16Y      C316 H16Z
//  
//  IMPR C21 O21 C22 O22    C31 O31 C32 O32
//  
//  !IC table from IC generate, geometry is guessed
//  IC HN1  C12  *N   HN2  1.0524  110.54  127.93  115.12   1.0338
//  IC HN1  C12  *N   HN3  1.0524  110.54 -112.33  100.76   1.0488
//  IC HN1  N    C12  C11  1.0524  110.54   70.07  107.99   1.5341
//  IC C11  N    *C12 H12A 1.5341  107.99 -122.80  109.40   1.1069
//  IC H12A N    *C12 H12B 1.1069  109.40 -119.69  107.75   1.1114
//  IC N    C12  C11  O12  1.5038  107.99   46.85  109.27   1.4315
//  IC O12  C12  *C11 H11A 1.4315  109.27 -121.18  109.30   1.1164
//  IC H11A C12  *C11 H11B 1.1164  109.30 -117.51  109.07   1.1179
//  IC C12  C11  O12  P    1.5341  109.27  178.59  119.49   1.5904
//  IC C11  O12  P    O11  1.4315  119.49  104.93  100.57   1.5835
//  IC O11  O12  *P   O13  1.5835  100.57 -114.66  107.37   1.4782
//  IC O11  O12  *P   O14  1.5835  100.57  115.52  107.48   1.4694
//  IC O12  P    O11  C1   1.5904  100.57  -68.41  122.45   1.4279
//  IC P    O11  C1   C2   1.5835  122.45  113.33  109.83   1.5458
//  IC C2   O11  *C1  HA   1.5458  109.83  118.28  108.95   1.1134
//  IC HA   O11  *C1  HB   1.1134  108.95  118.31  112.84   1.1153
//  IC O11  C1   C2   O21  1.4279  109.83 -169.38  109.43   1.4399
//  IC O21  C1   *C2  C3   1.4399  109.43 -120.76  111.51   1.5508
//  IC C3   C1   *C2  HS   1.5508  111.51 -116.85  107.06   1.1136
//  IC C1   C2   O21  C21  1.5458  109.43  123.06  117.42   1.3213
//  IC C2   O21  C21  C22  1.4399  117.42  163.64  109.74   1.5303
//  IC C22  O21  *C21 O22  1.5303  109.74 -176.86  126.01   1.2239
//  IC O21  C21  C22  C23  1.3213  109.74 -113.72  109.53   1.5428
//  IC C23  C21  *C22 H2R  1.5428  109.53  120.69  110.65   1.1107
//  IC H2R  C21  *C22 H2S  1.1107  110.65  118.78  108.83   1.1092
//  IC C1   C2   C3   O31  1.5458  111.51 -171.21  111.32   1.4465
//  IC O31  C2   *C3  HX   1.4465  111.32 -126.25  108.41   1.1159
//  IC HX   C2   *C3  HY   1.1159  108.41 -114.81  107.61   1.1132
//  IC C2   C3   O31  C31  1.5508  111.32 -117.52  117.59   1.3317
//  IC C3   O31  C31  C32  1.4465  117.59 -177.93  109.00   1.5333
//  IC C32  O31  *C31 O32  1.5333  109.00 -179.19  126.42   1.2107
//  IC O31  C31  C32  C33  1.3317  109.00 -176.00  111.40   1.5440
//  IC C33  C31  *C32 H2X  1.5440  111.40  120.79  108.80   1.1093
//  IC H2X  C31  *C32 H2Y  1.1093  108.80  118.57  108.70   1.1101
//  IC C21  C22  C23  C24  1.5303  109.53  168.08  112.83   1.5322
//  IC C24  C22  *C23 H3R  1.5322  112.83 -119.08  109.34   1.1146
//  IC H3R  C22  *C23 H3S  1.1146  109.34 -118.17  109.92   1.1133
//  IC C22  C23  C24  C25  1.5428  112.83  179.85  112.06   1.5333
//  IC C25  C23  *C24 H4R  1.5333  112.06  120.31  108.77   1.1150
//  IC H4R  C23  *C24 H4S  1.1150  108.77  117.76  110.16   1.1129
//  IC C23  C24  C25  C26  1.5322  112.06  172.89  112.33   1.5326
//  IC C26  C24  *C25 H5R  1.5326  112.33 -120.75  109.47   1.1135
//  IC H5R  C24  *C25 H5S  1.1135  109.47 -117.79  109.27   1.1131
//  IC C24  C25  C26  C27  1.5333  112.33  175.30  112.46   1.5342
//  IC C27  C25  *C26 H6R  1.5342  112.46  121.40  108.94   1.1138
//  IC H6R  C25  *C26 H6S  1.1138  108.94  117.47  109.32   1.1131
//  IC C25  C26  C27  C28  1.5326  112.46  176.92  112.22   1.5391
//  IC C28  C26  *C27 H7R  1.5391  112.22 -121.53  108.81   1.1141
//  IC H7R  C26  *C27 H7S  1.1141  108.81 -117.10  108.50   1.1141
//  IC C26  C27  C28  C29  1.5342  112.22  177.27  111.34   1.5073
//  IC C29  C27  *C28 H8R  1.5073  111.34  119.85  107.24   1.1140
//  IC H8R  C27  *C28 H8S  1.1140  107.24  115.81  109.06   1.1117
//  IC C27  C28  C29  C210 1.5391  111.34 -141.40  127.31   1.3462
//  IC C210 C28  *C29 H91  1.3462  127.31 -176.71  114.35   1.1001
//  IC C28  C29  C210 C211 1.5073  127.31    1.24  127.43   1.5089
//  IC C211 C29  *C21 H101 1.5089  127.43  179.21  118.33   1.1011
//  IC C29  C210 C211 C212 1.3462  127.43 -120.91  110.88   1.5393
//  IC C212 C210 *C21 H11R 1.5393  110.88  121.06  112.51   1.1124
//  IC H11R C210 *C21 H11S 1.1124  112.51  119.00  109.81   1.1127
//  IC C210 C211 C212 C213 1.5089  110.88 -176.36  112.76   1.5347
//  IC C213 C211 *C21 H12R 1.5347  112.76 -120.93  109.33   1.1142
//  IC H12R C211 *C21 H12S 1.1142  109.33 -118.17  109.94   1.1138
//  IC C211 C212 C213 C214 1.5393  112.76 -179.47  112.21   1.5338
//  IC C214 C212 *C21 H13R 1.5338  112.21  121.29  109.31   1.1130
//  IC H13R C212 *C21 H13S 1.1130  109.31  117.74  109.05   1.1131
//  IC C212 C213 C214 C215 1.5347  112.21 -178.99  112.92   1.5339
//  IC C215 C213 *C21 H14R 1.5339  112.92 -121.37  109.00   1.1134
//  IC H14R C213 *C21 H14S 1.1134  109.00 -117.34  109.08   1.1132
//  IC C213 C214 C215 C216 1.5338  112.92  179.95  112.20   1.5339
//  IC C216 C214 *C21 H15R 1.5339  112.20  121.17  109.14   1.1131
//  IC H15R C214 *C21 H15S 1.1131  109.14  117.63  109.22   1.1132
//  IC C214 C215 C216 C217 1.5339  112.20  179.53  112.96   1.5328
//  IC C217 C215 *C21 H16R 1.5328  112.96 -121.41  109.07   1.1135
//  IC H16R C215 *C21 H16S 1.1135  109.07 -117.43  109.05   1.1130
//  IC C215 C216 C217 C218 1.5339  112.96 -179.21  113.03   1.5305
//  IC C218 C216 *C21 H17R 1.5305  113.03  121.55  108.80   1.1140
//  IC H17R C216 *C21 H17S 1.1140  108.80  116.88  108.83   1.1142
//  IC C216 C217 C218 H18R 1.5328  113.03   60.41  110.37   1.1113
//  IC H18R C217 *C21 H18S 1.1113  110.37 -119.78  110.49   1.1115
//  IC H18R C217 *C21 H18T 1.1113  110.37  120.07  110.59   1.1111
//  IC C31  C32  C33  C34  1.5333  111.40  179.66  112.54   1.5345
//  IC C34  C32  *C33 H3X  1.5345  112.54 -121.73  109.66   1.1133
//  IC H3X  C32  *C33 H3Y  1.1133  109.66 -117.45  109.37   1.1151
//  IC C32  C33  C34  C35  1.5440  112.54  178.40  112.54   1.5346
//  IC C35  C33  *C34 H4X  1.5346  112.54  121.75  110.03   1.1131
//  IC H4X  C33  *C34 H4Y  1.1131  110.03  117.75  108.84   1.1139
//  IC C33  C34  C35  C36  1.5345  112.54 -175.14  112.09   1.5349
//  IC C36  C34  *C35 H5X  1.5349  112.09 -122.26  109.27   1.1127
//  IC H5X  C34  *C35 H5Y  1.1127  109.27 -117.42  109.08   1.1138
//  IC C34  C35  C36  C37  1.5346  112.09  174.19  113.84   1.5368
//  IC C37  C35  *C36 H6X  1.5368  113.84  122.38  109.13   1.1124
//  IC H6X  C35  *C36 H6Y  1.1124  109.13  117.02  108.50   1.1143
//  IC C35  C36  C37  C38  1.5349  113.84   65.26  113.87   1.5343
//  IC C38  C36  *C37 H7X  1.5343  113.87  120.83  108.55   1.1137
//  IC H7X  C36  *C37 H7Y  1.1137  108.55  116.91  109.10   1.1132
//  IC C36  C37  C38  C39  1.5368  113.87  178.14  112.45   1.5354
//  IC C39  C37  *C38 H8X  1.5354  112.45  121.43  109.97   1.1123
//  IC H8X  C37  *C38 H8Y  1.1123  109.97  117.71  108.91   1.1127
//  IC C37  C38  C39  C310 1.5343  112.45 -176.66  111.96   1.5320
//  IC C310 C38  *C39 H9X  1.5320  111.96  120.68  109.20   1.1133
//  IC H9X  C38  *C39 H9Y  1.1133  109.20  117.81  109.34   1.1127
//  IC C38  C39  C310 C311 1.5354  111.96  178.35  113.81   1.5336
//  IC C311 C39  *C31 H10X 1.5336  113.81 -120.14  108.22   1.1126
//  IC H10X C39  *C31 H10Y 1.1126  108.22 -117.07  109.45   1.1132
//  IC C39  C310 C311 C312 1.5320  113.81 -175.46  111.16   1.5334
//  IC C312 C310 *C31 H11X 1.5334  111.16  120.27  109.12   1.1138
//  IC H11X C310 *C31 H11Y 1.1138  109.12  118.20  110.02   1.1119
//  IC C310 C311 C312 C313 1.5336  111.16  173.60  113.47   1.5330
//  IC C313 C311 *C31 H12X 1.5330  113.47 -120.74  108.01   1.1140
//  IC H12X C311 *C31 H12Y 1.1140  108.01 -116.85  109.45   1.1130
//  IC C311 C312 C313 C314 1.5334  113.47 -174.75  111.86   1.5335
//  IC C314 C312 *C31 H13X 1.5335  111.86  120.28  108.66   1.1135
//  IC H13X C312 *C31 H13Y 1.1135  108.66  118.03  110.08   1.1125
//  IC C312 C313 C314 C315 1.5330  111.86  175.21  113.05   1.5325
//  IC C315 C313 *C31 H14X 1.5325  113.05 -120.81  108.37   1.1133
//  IC H14X C313 *C31 H14Y 1.1133  108.37 -117.18  109.40   1.1131
//  IC C313 C314 C315 C316 1.5335  113.05 -177.76  112.89   1.5300
//  IC C316 C314 *C31 H15X 1.5300  112.89  121.41  108.55   1.1149
//  IC H15X C314 *C31 H15Y 1.1149  108.55  117.05  109.21   1.1136
//  IC C314 C315 C316 H16X 1.5325  112.89   57.15  110.07   1.1113
//  IC H16X C315 *C31 H16Y 1.1113  110.07 -119.27  110.55   1.1106
//  IC H16X C315 *C31 H16Z 1.1113  110.07  120.81  110.70   1.1116
//  
//  !The following two residues (PALM and PCGL) and the two subsequent
//  !patches (EST1 and EST2) are a modular way to create DPPC.  
//  !See the comments with EST1 and EST2 for more details. adm jr., Jul 99
//  
//  RESI PALM        -1.00 ! Palmitate
//                         ! based on methylsulfate
//  
//  GROUP                               O1  O2 (-) 
//  ATOM C1   CL      0.62 !             \\ /
//  ATOM O1   OCL    -0.76 !              C1
//  ATOM O2   OCL    -0.76 !               |
//                         !               |
//  ATOM C2   CTL2   -0.28 !          H2A-C2-H2B
//  ATOM H2A  HAL2    0.09 !               |
//  ATOM H2B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C3   CTL2   -0.18 !          H3A-C3-H3B
//  ATOM H3A  HAL2    0.09 !               |
//  ATOM H3B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C4   CTL2   -0.18 !          H4A-C4-H4B
//  ATOM H4A  HAL2    0.09 !               |
//  ATOM H4B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C5   CTL2   -0.18 !          H5A-C5-H5B
//  ATOM H5A  HAL2    0.09 !               |
//  ATOM H5B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C6   CTL2   -0.18 !          H6A-C6-H6B
//  ATOM H6A  HAL2    0.09 !               |
//  ATOM H6B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C7   CTL2   -0.18 !          H7A-C7-H7B
//  ATOM H7A  HAL2    0.09 !               |
//  ATOM H7B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C8   CTL2   -0.18 !          H8A-C8-H8B
//  ATOM H8A  HAL2    0.09 !               |
//  ATOM H8B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C9   CTL2   -0.18 !          H9A-C9-H9B
//  ATOM H9A  HAL2    0.09 !               |
//  ATOM H9B  HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C10  CTL2   -0.18 !         H10A-C10-H10B
//  ATOM H10A HAL2    0.09 !               |
//  ATOM H10B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C11  CTL2   -0.18 !         H11A-C11-H11B
//  ATOM H11A HAL2    0.09 !               |
//  ATOM H11B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C12  CTL2   -0.18 !         H12A-C12-H12B
//  ATOM H12A HAL2    0.09 !               |
//  ATOM H12B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C13  CTL2   -0.18 !         H13A-C13-H13B
//  ATOM H13A HAL2    0.09 !               |
//  ATOM H13B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C14  CTL2   -0.18 !         H14A-C14-H14B
//  ATOM H14A HAL2    0.09 !               |
//  ATOM H14B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C15  CTL2   -0.18 !         H15A-C15-H15B
//  ATOM H15A HAL2    0.09 !               |
//  ATOM H15B HAL2    0.09 !               |
//  GROUP                  !               |
//  ATOM C16  CTL3   -0.27 !         H16A-C16-H16B
//  ATOM H16A HAL3    0.09 !               |
//  ATOM H16B HAL3    0.09 !             H16C
//  ATOM H16C HAL3    0.09 !
//  
//  BOND  C1  O1  C1  O2
//  BOND  C1  C2  C2  H2A  C2  H2B
//  BOND  C2  C3  C3  H3A  C3  H3B
//  BOND  C3  C4  C4  H4A  C4  H4B
//  BOND  C4  C5  C5  H5A  C5  H5B
//  BOND  C5  C6  C6  H6A  C6  H6B
//  BOND  C6  C7  C7  H7A  C7  H7B
//  BOND  C7  C8  C8  H8A  C8  H8B
//  BOND  C8  C9  C9  H9A  C9  H9B
//  BOND  C9  C10 C10 H10A C10 H10B
//  BOND  C10 C11 C11 H11A C11 H11B
//  BOND  C11 C12 C12 H12A C12 H12B
//  BOND  C12 C13 C13 H13A C13 H13B
//  BOND  C13 C14 C14 H14A C14 H14B
//  BOND  C14 C15 C15 H15A C15 H15B
//  BOND  C15 C16 C16 H16A C16 H16B C16 H16C
//  IMPR C1 O1 C2 O2
//  ACCE  O1
//  ACCE  O2
//  !IC table insufficent to create cartesian coordinates
//  IC O1   C2   *C1  O2   0.0000    0.00  180.00    0.00   0.0000
//  IC O1   C1   C2   C3   0.0000    0.00  180.00    0.00   0.0000
//  IC C3   C1   *C2  H2A  0.0000    0.00  120.00    0.00   0.0000
//  IC H2A  C1   *C2  H2B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C1   C2   C3   C4   0.0000    0.00  180.00    0.00   0.0000
//  IC C4   C2   *C3  H3A  0.0000    0.00  120.00    0.00   0.0000
//  IC H3A  C2   *C3  H3B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C2   C3   C4   C5   0.0000    0.00  180.00    0.00   0.0000
//  IC C5   C3   *C4  H4A  0.0000    0.00  120.00    0.00   0.0000
//  IC H4A  C3   *C4  H4B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C3   C4   C5   C6   0.0000    0.00  180.00    0.00   0.0000
//  IC C6   C4   *C5  H5A  0.0000    0.00  120.00    0.00   0.0000
//  IC H5A  C4   *C5  H5B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C4   C5   C6   C7   0.0000    0.00  180.00    0.00   0.0000
//  IC C7   C5   *C6  H6A  0.0000    0.00  120.00    0.00   0.0000
//  IC H6A  C5   *C6  H6B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C5   C6   C7   C8   0.0000    0.00  180.00    0.00   0.0000
//  IC C8   C6   *C7  H7A  0.0000    0.00  120.00    0.00   0.0000
//  IC H7A  C6   *C7  H7B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C6   C7   C8   C9   0.0000    0.00  180.00    0.00   0.0000
//  IC C9   C7   *C8  H8A  0.0000    0.00  120.00    0.00   0.0000
//  IC H8A  C7   *C8  H8B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C7   C8   C9   C10  0.0000    0.00  180.00    0.00   0.0000
//  IC C10  C8   *C9  H9A  0.0000    0.00  120.00    0.00   0.0000
//  IC H9A  C8   *C9  H9B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C8   C9   C10  C11  0.0000    0.00  180.00    0.00   0.0000
//  IC C11  C9   *C10 H10A 0.0000    0.00  120.00    0.00   0.0000
//  IC H10A C9   *C10 H10B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C9   C10  C11  C12  0.0000    0.00  180.00    0.00   0.0000
//  IC C12  C10  *C11 H11A 0.0000    0.00  120.00    0.00   0.0000
//  IC H11A C10  *C11 H11B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C10  C11  C12  C13  0.0000    0.00  180.00    0.00   0.0000
//  IC C13  C11  *C12 H12A 0.0000    0.00  120.00    0.00   0.0000
//  IC H12A C11  *C12 H12B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C11  C12  C13  C14  0.0000    0.00  180.00    0.00   0.0000
//  IC C14  C12  *C13 H13A 0.0000    0.00  120.00    0.00   0.0000
//  IC H13A C12  *C13 H13B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C12  C13  C14  C15  0.0000    0.00  180.00    0.00   0.0000
//  IC C15  C13  *C14 H14A 0.0000    0.00  120.00    0.00   0.0000
//  IC H14A C13  *C14 H14B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C13  C14  C15  C16  0.0000    0.00  180.00    0.00   0.0000
//  IC C16  C14  *C15 H15A 0.0000    0.00  120.00    0.00   0.0000
//  IC H15A C14  *C15 H15B 0.0000    0.00 -120.00    0.00   0.0000
//  IC C14  C15  C16  H16A 0.0000    0.00  180.00    0.00   0.0000
//  IC H16A C15  *C16 H16B 0.0000    0.00  120.00    0.00   0.0000
//  IC H16A C15  *C16 H16C 0.0000    0.00 -120.00    0.00   0.0000
//    
//  RESI PCGL         0.00 ! glycerolphosphorylcholine
//                         ! nomenclature for creation of DPPC
//  GROUP                  ! from PALM and PCGL via patches EST1 and EST2
//  ATOM N    NTL    -0.60 !
//  ATOM C5   CTL2   -0.10 !             |
//  ATOM C6   CTL5   -0.35 !           -C7-
//  ATOM C7   CTL5   -0.35 !             |
//  ATOM C8   CTL5   -0.35 !        |    |   |
//  ATOM H5A  HL      0.25 !       -C6---N---C8-     (+)
//  ATOM H5B  HL      0.25 !        |    |   |
//  ATOM H6A  HL      0.25 !             |
//  ATOM H6B  HL      0.25 !           -C5-
//  ATOM H6C  HL      0.25 !             |
//  ATOM H7A  HL      0.25 !             |
//  ATOM H7B  HL      0.25 !             |
//  ATOM H7C  HL      0.25 !             |
//  ATOM H8A  HL      0.25 !             |
//  ATOM H8B  HL      0.25 !             |
//  ATOM H8C  HL      0.25 !             |
//  GROUP                  !             |
//  ATOM C4   CTL2   -0.08 !             |
//  ATOM H4A  HAL2    0.09 !       H4A---C4---H4B
//  ATOM H4B  HAL2    0.09 !             |
//  ATOM P    PL      1.50 !    (-) OP3  OP2
//  ATOM OP3  O2L    -0.78 !          \ /
//  ATOM OP4  O2L    -0.78 !           P (+)
//  ATOM OP1  OSL    -0.57 !          / \
//  ATOM OP2  OSL    -0.57 !    (-) OP4  OP1
//  ATOM C3   CTL2   -0.08 !             |
//  ATOM H3A  HAL2    0.09 !        H3A-C3-H3B
//  ATOM H3B  HAL2    0.09 !             |
//  GROUP                  !             | 
//  ATOM C2   CTL1    0.14 !             |
//  ATOM H2A  HAL1    0.09 !        H2A-C2-O2-H2
//  ATOM O2   OHL    -0.66 !             |
//  ATOM H2   HOL     0.43 !             |       
//  GROUP                  !             |  
//  ATOM C1   CTL2    0.05 !             |
//  ATOM H1A  HAL2    0.09 !        H1A-C1-O1-H1
//  ATOM H1B  HAL2    0.09 !             |
//  ATOM O1   OHL    -0.66 !             H1B
//  ATOM H1   HOL     0.43 !
//  BOND N   C5   N   C6    N   C7    N   C8
//  BOND C5  C4   C4  OP2   OP2 P     P   OP1
//  BOND P   OP3  P   OP4
//  BOND OP1 C3   C3  C2    C2  C1
//  BOND C2  O2   C1  O1
//  BOND O1  H1   O2  H2
//  BOND C1  H1A  C1  H1B
//  BOND C2  H2A
//  BOND C3  H3A  C3  H3B
//  BOND C4  H4A  C4  H4B
//  BOND C5  H5A  C5  H5B
//  BOND C6  H6A  C6  H6B  C6  H6C
//  BOND C7  H7A  C7  H7B  C7  H7C
//  BOND C8  H8A  C8  H8B  C8  H8C
//  !IC table insufficent to create cartesian coordinates
//  IC C6   C5   *N   C7   0.0000    0.00  120.00    0.00   0.0000
//  IC C6   C5   *N   C8   0.0000    0.00 -120.00    0.00   0.0000
//  IC C6   N    C5   C4   0.0000    0.00  180.00    0.00   0.0000
//  IC C4   N    *C5  H5A  0.0000    0.00  120.00    0.00   0.0000
//  IC C4   N    *C5  H5B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C5   N    C6   H6A  0.0000    0.00  180.00    0.00   0.0000
//  IC H6A  N    *C6  H6B  0.0000    0.00  120.00    0.00   0.0000
//  IC H6A  N    *C6  H6C  0.0000    0.00 -120.00    0.00   0.0000
//  IC C5   N    C7   H7A  0.0000    0.00  180.00    0.00   0.0000
//  IC H7A  N    *C7  H7B  0.0000    0.00  120.00    0.00   0.0000
//  IC H7A  N    *C7  H7C  0.0000    0.00 -120.00    0.00   0.0000
//  IC C5   N    C8   H8A  0.0000    0.00  180.00    0.00   0.0000
//  IC H8A  N    *C8  H8B  0.0000    0.00  120.00    0.00   0.0000
//  IC H8A  N    *C8  H8C  0.0000    0.00 -120.00    0.00   0.0000
//  IC N    C5   C4   OP2  0.0000    0.00  180.00    0.00   0.0000
//  IC OP2  C5   *C4  H4A  0.0000    0.00  120.00    0.00   0.0000
//  IC OP2  C5   *C4  H4B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C5   C4   OP2  P    0.0000    0.00  180.00    0.00   0.0000
//  IC C4   OP2  P    OP1  0.0000    0.00  180.00    0.00   0.0000
//  IC OP1  OP2  *P   OP3  0.0000    0.00  120.00    0.00   0.0000
//  IC OP1  OP2  *P   OP4  0.0000    0.00 -120.00    0.00   0.0000
//  IC OP2  P    OP1  C3   0.0000    0.00  180.00    0.00   0.0000
//  IC P    OP1  C3   C2   0.0000    0.00  180.00    0.00   0.0000
//  IC C2   OP1  *C3  H3A  0.0000    0.00  120.00    0.00   0.0000
//  IC C2   OP1  *C3  H3B  0.0000    0.00 -120.00    0.00   0.0000
//  IC OP1  C3   C2   C1   0.0000    0.00  180.00    0.00   0.0000
//  IC C1   C3   *C2  O2   0.0000    0.00  120.00    0.00   0.0000
//  IC C1   C3   *C2  H2A  0.0000    0.00 -120.00    0.00   0.0000
//  IC C3   C2   O2   H2   0.0000    0.00  180.00    0.00   0.0000
//  IC C3   C2   C1   O1   0.0000    0.00  180.00    0.00   0.0000
//  IC O1   C2   *C1  H1A  0.0000    0.00  120.00    0.00   0.0000
//  IC O1   C2   *C1  H1B  0.0000    0.00 -120.00    0.00   0.0000
//  IC C2   C1   O1   H1   0.0000    0.00  180.00    0.00   0.0000
//  
//  PRES EST1        0.00 !patch to link O1 of PCGL to C1 of PALM
//  ! residue 1 is PCGL, residue 2 is PALM
//  DELETE ATOM 1H1
//  DELETE ATOM 2O2
//  ATOM 1C1  CTL2  -0.05 !     1H1A--1C1--1H1B
//  ATOM 1H1A HAL2   0.09 !            |
//  ATOM 1H1B HAL2   0.09 !            |   
//  ATOM 1O1  OSL   -0.34 !      2O1  1O1
//  ATOM 2C1  CL     0.63 !       \\ /    
//  ATOM 2O1  OBL   -0.52 !        2C1
//  ATOM 2C2  CTL2  -0.08 !         |     
//  ATOM 2H2A HAL2   0.09 !  2H2A--2C2--2H2B
//  ATOM 2H2B HAL2   0.09 !         |
//  BOND 1O1  2C1
//  
//  PRES EST2        0.00 !patch to link O2 of PCGL to C1 of PALM
//  ! residue 1 is PCGL, residue 2 is PALM
//  DELETE ATOM 1H2
//  DELETE ATOM 2O2
//  GROUP
//  ATOM 1C2  CTL1   0.04 !     1H2A--1C2--
//  ATOM 1H2A HAL1   0.09 !            |
//  ATOM 1O2  OSL   -0.34 !      2O1  1O2
//  ATOM 2C1  CL     0.63 !       \\ /
//  ATOM 2O1  OBL   -0.52 !        2C1
//  ATOM 2C2  CTL2  -0.08 !         |
//  ATOM 2H2A HAL2   0.09 !  2H2A--2C2--2H2B
//  ATOM 2H2B HAL2   0.09 !         |
//  BOND 1O2  2C1
//  
//  
//  ! fixed h-bond!
//  PRES HBND       0.00
//  DELETE ATOM 1HN
//  GROUP
//  ATOM 1N   NH1    -.32
//  GROUP
//  ATOM 2O   O      -0.35
//  BOND 1N 2O
//  END
//  
//  
}
}
}
}
*/