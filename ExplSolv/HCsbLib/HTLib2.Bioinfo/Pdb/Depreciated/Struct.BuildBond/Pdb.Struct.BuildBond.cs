﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTLib2.Bioinfo
{
    partial class PdbDepreciated
	{
        public partial class Struct
        {
            public interface IRes
            {
                string Name { get; }
            }
            // BOND
            //case 'GLY'; {'N  -CA -C  -O  '}
            //case 'ALA'; {'N  -CA -C  -O  ','CA -CB '}
            //case 'PRO'; {'N  -CA -C  -O  ','CA -CB -CG -CD ',...
            //             'N  -CD '}
            //case 'VAL'; {'N  -CA -C  -O  ','CA -CB -CG1',...
            //                                   'CB -CG2'}
            //case 'CYS'; {'N  -CA -C  -O  ','CA -CB -SG '}
            //                %assert(false); % if it comes here, 'CYS' passes the test. remove assertion code
            //case 'SER'; {'N  -CA -C  -O  ','CA -CB -OG '}
            //case 'THR'; {'N  -CA -C  -O  ','CA -CB -OG1',...
            //                                   'CB -CG2'}
            //case 'ILE'; {'N  -CA -C  -O  ','CA -CB -CG2',...
            //                                   'CB -CG1-CD1'}
            //case 'LEU'; {'N  -CA -C  -O  ','CA -CB -CG -CD1',...
            //                                       'CG -CD2'}
            //case 'ASP'; {'N  -CA -C  -O  ','CA -CB -CG -OD1',...
            //                                       'CG -OD2'}
            //case 'ASN'; {'N  -CA -C  -O  ','CA -CB -CG -OD1',...
            //                                       'CG -ND2'}
            //case 'HIS'; {'N  -CA -C  -O  ','CA -CB -CG -CD2-NE2',...
            //                                       'CG -ND1-CE1-NE2'}
            //case 'PHE'; {'N  -CA -C  -O  ','CA -CB -CG -CD1-CE1-CZ ',...
            //                                       'CG -CD2-CE2-CZ '}
            //case 'TYR'; {'N  -CA -C  -O  ','CA -CB -CG -CD1-CE1-CZ -OH ',...
            //                                       'CG -CD2-CE2-CZ '}
            //case 'TRP'; {'N  -CA -C  -O  ','CA -CB -CG -CD2-CE3-CZ3-CH2',...
            //                                           'CD2-CE2-CZ2-CH2',...
            //                                       'CG -CD1-NE1-CE2'     }
            //case 'MET'; {'N  -CA -C  -O  ','CA -CB -CG -SD -CE '}
            //case 'GLU'; {'N  -CA -C  -O  ','CA -CB -CG -CD -OE1',...
            //                                           'CD -OE2'}
            //case 'GLN'; {'N  -CA -C  -O  ','CA -CB -CG -CD -OE1',...
            //                                           'CD -NE2'}
            //case 'LYS'; {'N  -CA -C  -O  ','CA -CB -CG -CD -CE -NZ '}
            //case 'ARG'; {'N  -CA -C  -O  ','CA -CB -CG -CD -NE -CZ -NH1',...
            //                                                   'CZ -NH2'}



            //case 'GLY'; buildAnglesFromNamess({'N  -CA -C  -O  '});
            //case 'ALA'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB '});
            //case 'PRO'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD '});
            //case 'VAL'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG1',...
            //                                                         'CA -CB -CG2'});
            //case 'CYS'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -SG '});
            //    %assert(false);
            //case 'SER'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -OG '});
            //case 'THR'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -OG1',...
            //                                                         'CA -CB -CG2'});
            //case 'ILE'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG2',...
            //                                                         'CA -CB -CG1-CD1'});
            //case 'LEU'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD1',...
            //                                                             'CB -CG -CD2'});
            //case 'ASP'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -OD1',...
            //                                                             'CB -CG -OD2'});
            //case 'ASN'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -OD1',...
            //                                                             'CB -CG -ND2'});
            //case 'HIS'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD2-NE2-CE1',...
            //                                                             'CB -CG -ND1-CE1-NE2'});
            //case 'PHE'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD1-CE1-CZ -CE2',...
            //                                                             'CB -CG -CD2-CE2-CZ '});
            //case 'TYR'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD1-CE1-CZ -OH ',...
            //                                                             'CB -CG -CD2-CE2-CZ -OH '});
            //case 'TRP'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD2-CE3-CZ3-CH2-CZ2',...
            //                                                                 'CG -CD2-CE2-CZ2-CH2',...
            //                                                             'CB -CG -CD1-NE1'        });
            //case 'MET'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -SD -CE '});
            //case 'GLU'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD -OE1',...
            //                                                                 'CG -CD -OE2'});
            //case 'GLN'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD -OE1',...
            //                                                                 'CG -CD -NE2'});
            //case 'LYS'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD -CE -NZ '});
            //case 'ARG'; buildAnglesFromNamess({'N  -CA -C  -O  ','N  -CA -CB -CG -CD -NE -CZ -NH1',...
        }
    }
}
