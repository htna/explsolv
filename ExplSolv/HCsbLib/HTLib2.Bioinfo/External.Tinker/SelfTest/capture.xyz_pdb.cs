using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTLib2.Bioinfo
{
    public partial class Tinker
    {
        public partial class Selftest
        {
            public static readonly string[] selftest_pdb = new string[]
{
"TITLE     Gnomes, ROck Monsters And Chili Sauce",
"REMARK    THIS IS A SIMULATION BOX",
"CRYST1   23.600   26.979   12.873  90.00  90.00  90.00 P 1           1",
"MODEL        1",
"ATOM      1  N   LYS     1     -11.020 -12.540 -24.210  1.00  0.00            ",
"ATOM      2  H1  LYS     1     -10.790 -11.640 -24.580  1.00  0.00            ",
"ATOM      3  H2  LYS     1     -10.580 -12.660 -23.320  1.00  0.00            ",
"ATOM      4  H3  LYS     1     -10.700 -13.250 -24.840  1.00  0.00            ",
"ATOM      5  CA  LYS     1     -12.460 -12.650 -24.060  1.00  0.00            ",
"ATOM      6  HA  LYS     1     -12.740 -11.930 -23.430  1.00  0.00            ",
"ATOM      7  CB  LYS     1     -13.150 -12.430 -25.410  1.00  0.00            ",
"ATOM      8  HB1 LYS     1     -12.670 -11.710 -25.910  1.00  0.00            ",
"ATOM      9  HB2 LYS     1     -13.100 -13.280 -25.940  1.00  0.00            ",
"ATOM     10  CG  LYS     1     -14.610 -12.030 -25.280  1.00  0.00            ",
"ATOM     11  HG1 LYS     1     -15.070 -12.680 -24.670  1.00  0.00            ",
"ATOM     12  HG2 LYS     1     -14.650 -11.110 -24.890  1.00  0.00            ",
"ATOM     13  CD  LYS     1     -15.320 -12.030 -26.620  1.00  0.00            ",
"ATOM     14  HD1 LYS     1     -15.140 -11.160 -27.090  1.00  0.00            ",
"ATOM     15  HD2 LYS     1     -14.970 -12.790 -27.180  1.00  0.00            ",
"ATOM     16  CE  LYS     1     -16.820 -12.190 -26.420  1.00  0.00            ",
"ATOM     17  HE1 LYS     1     -17.200 -11.330 -26.080  1.00  0.00            ",
"ATOM     18  HE2 LYS     1     -17.250 -12.430 -27.280  1.00  0.00            ",
"ATOM     19  NZ  LYS     1     -17.100 -13.270 -25.420  1.00  0.00            ",
"ATOM     20  HZ1 LYS     1     -18.090 -13.360 -25.290  1.00  0.00            ",
"ATOM     21  HZ2 LYS     1     -16.730 -14.140 -25.750  1.00  0.00            ",
"ATOM     22  HZ3 LYS     1     -16.680 -13.040 -24.540  1.00  0.00            ",
"ATOM     23  C   LYS     1     -12.800 -14.020 -23.500  1.00  0.00            ",
"ATOM     24  O   LYS     1     -12.120 -15.000 -23.800  1.00  0.00            ",
"ATOM     25  N   LEU     2     -13.830 -14.080 -22.660  1.00  0.00            ",
"ATOM     26  HN  LEU     2     -14.300 -13.240 -22.400  1.00  0.00            ",
"ATOM     27  CA  LEU     2     -14.300 -15.350 -22.110  1.00  0.00            ",
"ATOM     28  HA  LEU     2     -13.470 -15.910 -22.010  1.00  0.00            ",
"ATOM     29  CB  LEU     2     -14.970 -15.140 -20.760  1.00  0.00            ",
"ATOM     30  HB1 LEU     2     -15.720 -14.480 -20.890  1.00  0.00            ",
"ATOM     31  HB2 LEU     2     -15.350 -16.010 -20.470  1.00  0.00            ",
"ATOM     32  CG  LEU     2     -14.080 -14.610 -19.640  1.00  0.00            ",
"ATOM     33  HG  LEU     2     -13.760 -13.690 -19.860  1.00  0.00            ",
"ATOM     34  CD1 LEU     2     -14.870 -14.540 -18.350  1.00  0.00            ",
"ATOM     35 1HD1 LEU     2     -14.290 -14.200 -17.610  1.00  0.00            ",
"ATOM     36 2HD1 LEU     2     -15.650 -13.930 -18.470  1.00  0.00            ",
"ATOM     37 3HD1 LEU     2     -15.200 -15.460 -18.110  1.00  0.00            ",
"ATOM     38  CD2 LEU     2     -12.870 -15.500 -19.480  1.00  0.00            ",
"ATOM     39 1HD2 LEU     2     -12.290 -15.150 -18.750  1.00  0.00            ",
"ATOM     40 2HD2 LEU     2     -13.170 -16.430 -19.260  1.00  0.00            ",
"ATOM     41 3HD2 LEU     2     -12.360 -15.520 -20.340  1.00  0.00            ",
"ATOM     42  C   LEU     2     -15.270 -16.040 -23.050  1.00  0.00            ",
"ATOM     43  O   LEU     2     -16.370 -15.530 -23.300  1.00  0.00            ",
"ATOM     44  N   LYS     3     -14.870 -17.180 -23.570  1.00  0.00            ",
"ATOM     45  HN  LYS     3     -13.960 -17.530 -23.350  1.00  0.00            ",
"ATOM     46  CA  LYS     3     -15.720 -17.950 -24.470  1.00  0.00            ",
"ATOM     47  HA  LYS     3     -16.500 -17.360 -24.670  1.00  0.00            ",
"ATOM     48  CB  LYS     3     -14.960 -18.300 -25.740  1.00  0.00            ",
"ATOM     49  HB1 LYS     3     -14.170 -18.870 -25.490  1.00  0.00            ",
"ATOM     50  HB2 LYS     3     -15.560 -18.820 -26.340  1.00  0.00            ",
"ATOM     51  CG  LYS     3     -14.450 -17.110 -26.500  1.00  0.00            ",
"ATOM     52  HG1 LYS     3     -13.940 -16.520 -25.880  1.00  0.00            ",
"ATOM     53  HG2 LYS     3     -13.840 -17.420 -27.230  1.00  0.00            ",
"ATOM     54  CD  LYS     3     -15.580 -16.310 -27.120  1.00  0.00            ",
"ATOM     55  HD1 LYS     3     -16.280 -16.150 -26.430  1.00  0.00            ",
"ATOM     56  HD2 LYS     3     -15.220 -15.440 -27.440  1.00  0.00            ",
"ATOM     57  CE  LYS     3     -16.200 -17.050 -28.290  1.00  0.00            ",
"ATOM     58  HE1 LYS     3     -15.470 -17.410 -28.880  1.00  0.00            ",
"ATOM     59  HE2 LYS     3     -16.750 -17.810 -27.940  1.00  0.00            ",
"ATOM     60  NZ  LYS     3     -17.080 -16.150 -29.090  1.00  0.00            ",
"ATOM     61  HZ1 LYS     3     -17.470 -16.670 -29.850  1.00  0.00            ",
"ATOM     62  HZ2 LYS     3     -17.810 -15.800 -28.510  1.00  0.00            ",
"ATOM     63  HZ3 LYS     3     -16.540 -15.390 -29.450  1.00  0.00            ",
"ATOM     64  C   LYS     3     -16.190 -19.230 -23.800  1.00  0.00            ",
"ATOM     65  O   LYS     3     -15.670 -19.640 -22.750  1.00  0.00            ",
"ATOM     66  N   VAL     4     -17.160 -19.890 -24.400  1.00  0.00            ",
"ATOM     67  HN  VAL     4     -17.570 -19.510 -25.230  1.00  0.00            ",
"ATOM     68  CA  VAL     4     -17.630 -21.160 -23.890  1.00  0.00            ",
"ATOM     69  HA  VAL     4     -17.050 -21.350 -23.100  1.00  0.00            ",
"ATOM     70  CB  VAL     4     -19.110 -21.060 -23.450  1.00  0.00            ",
"ATOM     71  HB  VAL     4     -19.660 -20.730 -24.220  1.00  0.00            ",
"ATOM     72  CG1 VAL     4     -19.650 -22.430 -23.050  1.00  0.00            ",
"ATOM     73 1HG1 VAL     4     -20.610 -22.340 -22.770  1.00  0.00            ",
"ATOM     74 2HG1 VAL     4     -19.590 -23.050 -23.830  1.00  0.00            ",
"ATOM     75 3HG1 VAL     4     -19.110 -22.800 -22.290  1.00  0.00            ",
"ATOM     76  CG2 VAL     4     -19.250 -20.050 -22.320  1.00  0.00            ",
"ATOM     77 1HG2 VAL     4     -20.210 -19.990 -22.040  1.00  0.00            ",
"ATOM     78 2HG2 VAL     4     -18.690 -20.350 -21.540  1.00  0.00            ",
"ATOM     79 3HG2 VAL     4     -18.940 -19.150 -22.630  1.00  0.00            ",
"ATOM     80  C   VAL     4     -17.490 -22.240 -24.950  1.00  0.00            ",
"ATOM     81  O   VAL     4     -17.800 -22.000 -26.120  1.00  0.00            ",
"ATOM     82  N   LEU     5     -17.020 -23.410 -24.550  1.00  0.00            ",
"ATOM     83  HN  LEU     5     -16.650 -23.480 -23.620  1.00  0.00            ",
"ATOM     84  CA  LEU     5     -17.030 -24.600 -25.390  1.00  0.00            ",
"ATOM     85  HA  LEU     5     -17.520 -24.380 -26.230  1.00  0.00            ",
"ATOM     86  CB  LEU     5     -15.600 -25.010 -25.770  1.00  0.00            ",
"ATOM     87  HB1 LEU     5     -15.170 -24.220 -26.200  1.00  0.00            ",
"ATOM     88  HB2 LEU     5     -15.120 -25.230 -24.920  1.00  0.00            ",
"ATOM     89  CG  LEU     5     -15.430 -26.200 -26.720  1.00  0.00            ",
"ATOM     90  HG  LEU     5     -15.880 -27.000 -26.310  1.00  0.00            ",
"ATOM     91  CD1 LEU     5     -16.080 -25.900 -28.050  1.00  0.00            ",
"ATOM     92 1HD1 LEU     5     -15.970 -26.680 -28.660  1.00  0.00            ",
"ATOM     93 2HD1 LEU     5     -17.060 -25.730 -27.910  1.00  0.00            ",
"ATOM     94 3HD1 LEU     5     -15.660 -25.090 -28.460  1.00  0.00            ",
"ATOM     95  CD2 LEU     5     -13.960 -26.540 -26.920  1.00  0.00            ",
"ATOM     96 1HD2 LEU     5     -13.870 -27.320 -27.540  1.00  0.00            ",
"ATOM     97 2HD2 LEU     5     -13.480 -25.750 -27.310  1.00  0.00            ",
"ATOM     98 3HD2 LEU     5     -13.540 -26.770 -26.030  1.00  0.00            ",
"ATOM     99  C   LEU     5     -17.720 -25.690 -24.600  1.00  0.00            ",
"ATOM    100  O   LEU     5     -17.300 -26.000 -23.480  1.00  0.00            ",
"ATOM    101  N   GLY     6     -18.780 -26.270 -25.150  1.00  0.00            ",
"ATOM    102  HN  GLY     6     -19.040 -26.040 -26.080  1.00  0.00            ",
"ATOM    103  CA  GLY     6     -19.560 -27.220 -24.380  1.00  0.00            ",
"ATOM    104  HA1 GLY     6     -18.950 -27.620 -23.700  1.00  0.00            ",
"ATOM    105  HA2 GLY     6     -20.280 -26.700 -23.920  1.00  0.00            ",
"ATOM    106  C   GLY     6     -20.190 -28.320 -25.190  1.00  0.00            ",
"ATOM    107  O   GLY     6     -20.040 -28.390 -26.420  1.00  0.00            ",
"ATOM    108  N   ASP     7     -20.910 -29.190 -24.490  1.00  0.00            ",
"ATOM    109  HN  ASP     7     -21.020 -29.030 -23.510  1.00  0.00            ",
"ATOM    110  CA  ASP     7     -21.540 -30.350 -25.090  1.00  0.00            ",
"ATOM    111  HA  ASP     7     -21.420 -30.250 -26.070  1.00  0.00            ",
"ATOM    112  CB  ASP     7     -20.890 -31.630 -24.580  1.00  0.00            ",
"ATOM    113  HB1 ASP     7     -20.940 -31.650 -23.580  1.00  0.00            ",
"ATOM    114  HB2 ASP     7     -21.380 -32.420 -24.950  1.00  0.00            ",
"ATOM    115  CG  ASP     7     -19.440 -31.740 -24.980  1.00  0.00            ",
"ATOM    116  OD1 ASP     7     -19.200 -31.950 -26.180  1.00  0.00            ",
"ATOM    117  OD2 ASP     7     -18.550 -31.600 -24.110  1.00  0.00            ",
"ATOM    118  C   ASP     7     -23.010 -30.370 -24.730  1.00  0.00            ",
"ATOM    119  O   ASP     7     -23.410 -29.810 -23.710  1.00  0.00            ",
"ATOM    120  N   VAL     8     -23.810 -31.040 -25.560  1.00  0.00            ",
"ATOM    121  HN  VAL     8     -23.420 -31.430 -26.390  1.00  0.00            ",
"ATOM    122  CA  VAL     8     -25.230 -31.210 -25.290  1.00  0.00            ",
"ATOM    123  HA  VAL     8     -25.430 -30.550 -24.570  1.00  0.00            ",
"ATOM    124  CB  VAL     8     -26.080 -30.920 -26.540  1.00  0.00            ",
"ATOM    125  HB  VAL     8     -25.860 -31.600 -27.240  1.00  0.00            ",
"ATOM    126  CG1 VAL     8     -27.550 -31.030 -26.210  1.00  0.00            ",
"ATOM    127 1HG1 VAL     8     -28.090 -30.850 -27.030  1.00  0.00            ",
"ATOM    128 2HG1 VAL     8     -27.750 -31.960 -25.880  1.00  0.00            ",
"ATOM    129 3HG1 VAL     8     -27.790 -30.370 -25.500  1.00  0.00            ",
"ATOM    130  CG2 VAL     8     -25.770 -29.550 -27.090  1.00  0.00            ",
"ATOM    131 1HG2 VAL     8     -26.330 -29.390 -27.900  1.00  0.00            ",
"ATOM    132 2HG2 VAL     8     -25.970 -28.860 -26.400  1.00  0.00            ",
"ATOM    133 3HG2 VAL     8     -24.800 -29.500 -27.340  1.00  0.00            ",
"ATOM    134  C   VAL     8     -25.490 -32.630 -24.840  1.00  0.00            ",
"ATOM    135  O   VAL     8     -25.040 -33.580 -25.470  1.00  0.00            ",
"ATOM    136  N   ILE     9     -26.230 -32.780 -23.750  1.00  0.00            ",
"ATOM    137  HN  ILE     9     -26.530 -31.970 -23.240  1.00  0.00            ",
"ATOM    138  CA  ILE     9     -26.610 -34.110 -23.280  1.00  0.00            ",
"ATOM    139  HA  ILE     9     -26.370 -34.700 -24.060  1.00  0.00            ",
"ATOM    140  CB  ILE     9     -25.840 -34.540 -22.010  1.00  0.00            ",
"ATOM    141  HB  ILE     9     -26.090 -35.490 -21.800  1.00  0.00            ",
"ATOM    142  CG2 ILE     9     -24.340 -34.460 -22.250  1.00  0.00            ",
"ATOM    143 1HG2 ILE     9     -23.860 -34.740 -21.420  1.00  0.00            ",
"ATOM    144 2HG2 ILE     9     -24.090 -35.070 -23.000  1.00  0.00            ",
"ATOM    145 3HG2 ILE     9     -24.090 -33.520 -22.490  1.00  0.00            ",
"ATOM    146  CG1 ILE     9     -26.220 -33.670 -20.810  1.00  0.00            ",
"ATOM    147 1HG1 ILE     9     -25.890 -32.740 -20.980  1.00  0.00            ",
"ATOM    148 2HG1 ILE     9     -27.220 -33.660 -20.730  1.00  0.00            ",
"ATOM    149  CD  ILE     9     -25.640 -34.160 -19.480  1.00  0.00            ",
"ATOM    150  HD1 ILE     9     -25.920 -33.550 -18.750  1.00  0.00            ",
"ATOM    151  HD2 ILE     9     -25.970 -35.080 -19.290  1.00  0.00            ",
"ATOM    152  HD3 ILE     9     -24.640 -34.170 -19.540  1.00  0.00            ",
"ATOM    153  C   ILE     9     -28.100 -34.200 -23.000  1.00  0.00            ",
"ATOM    154  O   ILE     9     -28.780 -33.180 -22.920  1.00  0.00            ",
"ATOM    155  N   GLU    10     -28.600 -35.420 -22.870  1.00  0.00            ",
"ATOM    156  HN  GLU    10     -28.000 -36.210 -23.030  1.00  0.00            ",
"ATOM    157  CA  GLU    10     -29.980 -35.660 -22.500  1.00  0.00            ",
"ATOM    158  HA  GLU    10     -30.490 -34.810 -22.630  1.00  0.00            ",
"ATOM    159  CB  GLU    10     -30.570 -36.760 -23.390  1.00  0.00            ",
"ATOM    160  HB1 GLU    10     -30.610 -36.420 -24.330  1.00  0.00            ",
"ATOM    161  HB2 GLU    10     -29.960 -37.550 -23.350  1.00  0.00            ",
"ATOM    162  CG  GLU    10     -31.960 -37.220 -23.000  1.00  0.00            ",
"ATOM    163  HG1 GLU    10     -32.150 -38.090 -23.440  1.00  0.00            ",
"ATOM    164  HG2 GLU    10     -31.990 -37.340 -22.000  1.00  0.00            ",
"ATOM    165  CD  GLU    10     -33.030 -36.230 -23.390  1.00  0.00            ",
"ATOM    166  OE1 GLU    10     -32.730 -35.310 -24.180  1.00  0.00            ",
"ATOM    167  OE2 GLU    10     -34.180 -36.370 -22.920  1.00  0.00            ",
"ATOM    168  C   GLU    10     -29.990 -36.120 -21.060  1.00  0.00            ",
"ATOM    169  O   GLU    10     -29.300 -37.080 -20.700  1.00  0.00            ",
"ATOM    170  N   VAL    11     -30.740 -35.410 -20.230  1.00  0.00            ",
"ATOM    171  HN  VAL    11     -31.260 -34.630 -20.580  1.00  0.00            ",
"ATOM    172  CA  VAL    11     -30.820 -35.750 -18.810  1.00  0.00            ",
"ATOM    173  HA  VAL    11     -30.250 -36.560 -18.730  1.00  0.00            ",
"ATOM    174  CB  VAL    11     -30.280 -34.620 -17.950  1.00  0.00            ",
"ATOM    175  HB  VAL    11     -30.380 -34.850 -16.980  1.00  0.00            ",
"ATOM    176  CG1 VAL    11     -28.800 -34.400 -18.210  1.00  0.00            ",
"ATOM    177 1HG1 VAL    11     -28.460 -33.660 -17.640  1.00  0.00            ",
"ATOM    178 2HG1 VAL    11     -28.300 -35.240 -18.000  1.00  0.00            ",
"ATOM    179 3HG1 VAL    11     -28.670 -34.170 -19.170  1.00  0.00            ",
"ATOM    180  CG2 VAL    11     -31.080 -33.360 -18.190  1.00  0.00            ",
"ATOM    181 1HG2 VAL    11     -30.720 -32.620 -17.620  1.00  0.00            ",
"ATOM    182 2HG2 VAL    11     -31.000 -33.100 -19.160  1.00  0.00            ",
"ATOM    183 3HG2 VAL    11     -32.040 -33.520 -17.970  1.00  0.00            ",
"ATOM    184  C   VAL    11     -32.250 -36.040 -18.390  1.00  0.00            ",
"ATOM    185  OT1 VAL    11     -33.200 -35.730 -19.120  1.00  0.00            ",
"ATOM    186  OT2 VAL    11     -32.460 -36.590 -17.310  1.00  0.00            ",
"TER",
"ENDMDL",
};
        }
    }
}