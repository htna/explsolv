#
#
#  ############################################################
#  ##                                                        ##
#  ##  compile.make  --  compile each of the TINKER modules  ##
#  ##                 (g95 for Linux Version)                ##
#  ##                                                        ##
#  ############################################################
#
#
g95 -c -O -o ./o/active.o     ../active.f
g95 -c -O -o ./o/alchemy.o    ../alchemy.f
g95 -c -O -o ./o/analysis.o   ../analysis.f
g95 -c -O -o ./o/analyze.o    ../analyze.f
g95 -c -O -o ./o/angles.o     ../angles.f
g95 -c -O -o ./o/anneal.o     ../anneal.f
g95 -c -O -o ./o/archive.o    ../archive.f
g95 -c -O -o ./o/attach.o     ../attach.f
g95 -c -O -o ./o/basefile.o   ../basefile.f
g95 -c -O -o ./o/beeman.o     ../beeman.f
g95 -c -O -o ./o/bicubic.o    ../bicubic.f
g95 -c -O -o ./o/bitors.o     ../bitors.f
g95 -c -O -o ./o/bonds.o      ../bonds.f
g95 -c -O -o ./o/born.o       ../born.f
g95 -c -O -o ./o/bounds.o     ../bounds.f
g95 -c -O -o ./o/bussi.o      ../bussi.f
g95 -c -O -o ./o/calendar.o   ../calendar.f
g95 -c -O -o ./o/center.o     ../center.f
g95 -c -O -o ./o/chkpole.o    ../chkpole.f
g95 -c -O -o ./o/chkring.o    ../chkring.f
g95 -c -O -o ./o/chkxyz.o     ../chkxyz.f
g95 -c -O -o ./o/cholesky.o   ../cholesky.f
g95 -c -O -o ./o/clock.o      ../clock.f
g95 -c -O -o ./o/cluster.o    ../cluster.f
g95 -c -O -o ./o/column.o     ../column.f
g95 -c -O -o ./o/command.o    ../command.f
g95 -c -O -o ./o/connect.o    ../connect.f
g95 -c -O -o ./o/connolly.o   ../connolly.f
g95 -c -O -o ./o/control.o    ../control.f
g95 -c -O -o ./o/correlate.o  ../correlate.f
g95 -c -O -o ./o/crystal.o    ../crystal.f
g95 -c -O -o ./o/cspline.o    ../cspline.f
g95 -c -O -o ./o/cutoffs.o    ../cutoffs.f
g95 -c -O -o ./o/deflate.o    ../deflate.f
g95 -c -O -o ./o/delete.o     ../delete.f
g95 -c -O -o ./o/diagq.o      ../diagq.f
g95 -c -O -o ./o/diffeq.o     ../diffeq.f
g95 -c -O -o ./o/diffuse.o    ../diffuse.f
g95 -c -O -o ./o/distgeom.o   ../distgeom.f
g95 -c -O -o ./o/document.o   ../document.f
g95 -c -O -o ./o/dynamic.o    ../dynamic.f
g95 -c -O -o ./o/eangang.o    ../eangang.f
g95 -c -O -o ./o/eangang1.o   ../eangang1.f
g95 -c -O -o ./o/eangang2.o   ../eangang2.f
g95 -c -O -o ./o/eangang3.o   ../eangang3.f
g95 -c -O -o ./o/eangle.o     ../eangle.f
g95 -c -O -o ./o/eangle1.o    ../eangle1.f
g95 -c -O -o ./o/eangle2.o    ../eangle2.f
g95 -c -O -o ./o/eangle3.o    ../eangle3.f
g95 -c -O -o ./o/ebond.o      ../ebond.f
g95 -c -O -o ./o/ebond1.o     ../ebond1.f
g95 -c -O -o ./o/ebond2.o     ../ebond2.f
g95 -c -O -o ./o/ebond3.o     ../ebond3.f
g95 -c -O -o ./o/ebuck.o      ../ebuck.f
g95 -c -O -o ./o/ebuck1.o     ../ebuck1.f
g95 -c -O -o ./o/ebuck2.o     ../ebuck2.f
g95 -c -O -o ./o/ebuck3.o     ../ebuck3.f
g95 -c -O -o ./o/echarge.o    ../echarge.f
g95 -c -O -o ./o/echarge1.o   ../echarge1.f
g95 -c -O -o ./o/echarge2.o   ../echarge2.f
g95 -c -O -o ./o/echarge3.o   ../echarge3.f
g95 -c -O -o ./o/echgdpl.o    ../echgdpl.f
g95 -c -O -o ./o/echgdpl1.o   ../echgdpl1.f
g95 -c -O -o ./o/echgdpl2.o   ../echgdpl2.f
g95 -c -O -o ./o/echgdpl3.o   ../echgdpl3.f
g95 -c -O -o ./o/edipole.o    ../edipole.f
g95 -c -O -o ./o/edipole1.o   ../edipole1.f
g95 -c -O -o ./o/edipole2.o   ../edipole2.f
g95 -c -O -o ./o/edipole3.o   ../edipole3.f
g95 -c -O -o ./o/egauss.o     ../egauss.f
g95 -c -O -o ./o/egauss1.o    ../egauss1.f
g95 -c -O -o ./o/egauss2.o    ../egauss2.f
g95 -c -O -o ./o/egauss3.o    ../egauss3.f
g95 -c -O -o ./o/egeom.o      ../egeom.f
g95 -c -O -o ./o/egeom1.o     ../egeom1.f
g95 -c -O -o ./o/egeom2.o     ../egeom2.f
g95 -c -O -o ./o/egeom3.o     ../egeom3.f
g95 -c -O -o ./o/ehal.o       ../ehal.f
g95 -c -O -o ./o/ehal1.o      ../ehal1.f
g95 -c -O -o ./o/ehal2.o      ../ehal2.f
g95 -c -O -o ./o/ehal3.o      ../ehal3.f
g95 -c -O -o ./o/eimprop.o    ../eimprop.f
g95 -c -O -o ./o/eimprop1.o   ../eimprop1.f
g95 -c -O -o ./o/eimprop2.o   ../eimprop2.f
g95 -c -O -o ./o/eimprop3.o   ../eimprop3.f
g95 -c -O -o ./o/eimptor.o    ../eimptor.f
g95 -c -O -o ./o/eimptor1.o   ../eimptor1.f
g95 -c -O -o ./o/eimptor2.o   ../eimptor2.f
g95 -c -O -o ./o/eimptor3.o   ../eimptor3.f
g95 -c -O -o ./o/elj.o        ../elj.f
g95 -c -O -o ./o/elj1.o       ../elj1.f
g95 -c -O -o ./o/elj2.o       ../elj2.f
g95 -c -O -o ./o/elj3.o       ../elj3.f
g95 -c -O -o ./o/embed.o      ../embed.f
g95 -c -O -o ./o/emetal.o     ../emetal.f
g95 -c -O -o ./o/emetal1.o    ../emetal1.f
g95 -c -O -o ./o/emetal2.o    ../emetal2.f
g95 -c -O -o ./o/emetal3.o    ../emetal3.f
g95 -c -O -o ./o/emm3hb.o     ../emm3hb.f
g95 -c -O -o ./o/emm3hb1.o    ../emm3hb1.f
g95 -c -O -o ./o/emm3hb2.o    ../emm3hb2.f
g95 -c -O -o ./o/emm3hb3.o    ../emm3hb3.f
g95 -c -O -o ./o/empole.o     ../empole.f
g95 -c -O -o ./o/empole1.o    ../empole1.f
g95 -c -O -o ./o/empole2.o    ../empole2.f
g95 -c -O -o ./o/empole3.o    ../empole3.f
g95 -c -O -o ./o/energy.o     ../energy.f
g95 -c -O -o ./o/eopbend.o    ../eopbend.f
g95 -c -O -o ./o/eopbend1.o   ../eopbend1.f
g95 -c -O -o ./o/eopbend2.o   ../eopbend2.f
g95 -c -O -o ./o/eopbend3.o   ../eopbend3.f
g95 -c -O -o ./o/eopdist.o    ../eopdist.f
g95 -c -O -o ./o/eopdist1.o   ../eopdist1.f
g95 -c -O -o ./o/eopdist2.o   ../eopdist2.f
g95 -c -O -o ./o/eopdist3.o   ../eopdist3.f
g95 -c -O -o ./o/epitors.o    ../epitors.f
g95 -c -O -o ./o/epitors1.o   ../epitors1.f
g95 -c -O -o ./o/epitors2.o   ../epitors2.f
g95 -c -O -o ./o/epitors3.o   ../epitors3.f
g95 -c -O -o ./o/erf.o        ../erf.f
g95 -c -O -o ./o/erxnfld.o    ../erxnfld.f
g95 -c -O -o ./o/erxnfld1.o   ../erxnfld1.f
g95 -c -O -o ./o/erxnfld2.o   ../erxnfld2.f
g95 -c -O -o ./o/erxnfld3.o   ../erxnfld3.f
g95 -c -O -o ./o/esolv.o      ../esolv.f
g95 -c -O -o ./o/esolv1.o     ../esolv1.f
g95 -c -O -o ./o/esolv2.o     ../esolv2.f
g95 -c -O -o ./o/esolv3.o     ../esolv3.f
g95 -c -O -o ./o/estrbnd.o    ../estrbnd.f
g95 -c -O -o ./o/estrbnd1.o   ../estrbnd1.f
g95 -c -O -o ./o/estrbnd2.o   ../estrbnd2.f
g95 -c -O -o ./o/estrbnd3.o   ../estrbnd3.f
g95 -c -O -o ./o/estrtor.o    ../estrtor.f
g95 -c -O -o ./o/estrtor1.o   ../estrtor1.f
g95 -c -O -o ./o/estrtor2.o   ../estrtor2.f
g95 -c -O -o ./o/estrtor3.o   ../estrtor3.f
g95 -c -O -o ./o/etors.o      ../etors.f
g95 -c -O -o ./o/etors1.o     ../etors1.f
g95 -c -O -o ./o/etors2.o     ../etors2.f
g95 -c -O -o ./o/etors3.o     ../etors3.f
g95 -c -O -o ./o/etortor.o    ../etortor.f
g95 -c -O -o ./o/etortor1.o   ../etortor1.f
g95 -c -O -o ./o/etortor2.o   ../etortor2.f
g95 -c -O -o ./o/etortor3.o   ../etortor3.f
g95 -c -O -o ./o/eurey.o      ../eurey.f
g95 -c -O -o ./o/eurey1.o     ../eurey1.f
g95 -c -O -o ./o/eurey2.o     ../eurey2.f
g95 -c -O -o ./o/eurey3.o     ../eurey3.f
g95 -c -O -o ./o/evcorr.o     ../evcorr.f
g95 -c -O -o ./o/extra.o      ../extra.f
g95 -c -O -o ./o/extra1.o     ../extra1.f
g95 -c -O -o ./o/extra2.o     ../extra2.f
g95 -c -O -o ./o/extra3.o     ../extra3.f
g95 -c -O -o ./o/fatal.o      ../fatal.f
g95 -c -O -o ./o/fft3d.o      ../fft3d.f
g95 -c -O -o ./o/fftpack.o    ../fftpack.f
g95 -c -O -o ./o/field.o      ../field.f
g95 -c -O -o ./o/final.o      ../final.f
g95 -c -O -o ./o/flatten.o    ../flatten.f
g95 -c -O -o ./o/freeunit.o   ../freeunit.f
g95 -c -O -o ./o/gda.o        ../gda.f
g95 -c -O -o ./o/geometry.o   ../geometry.f
g95 -c -O -o ./o/getint.o     ../getint.f
g95 -c -O -o ./o/getkey.o     ../getkey.f
g95 -c -O -o ./o/getmol.o     ../getmol.f
g95 -c -O -o ./o/getmol2.o    ../getmol2.f
g95 -c -O -o ./o/getnumb.o    ../getnumb.f
g95 -c -O -o ./o/getpdb.o     ../getpdb.f
g95 -c -O -o ./o/getprm.o     ../getprm.f
g95 -c -O -o ./o/getref.o     ../getref.f
g95 -c -O -o ./o/getstring.o  ../getstring.f
g95 -c -O -o ./o/gettext.o    ../gettext.f
g95 -c -O -o ./o/getword.o    ../getword.f
g95 -c -O -o ./o/getxyz.o     ../getxyz.f
g95 -c -O -o ./o/ghmcstep.o   ../ghmcstep.f
g95 -c -O -o ./o/gradient.o   ../gradient.f
g95 -c -O -o ./o/gradrgd.o    ../gradrgd.f
g95 -c -O -o ./o/gradrot.o    ../gradrot.f
g95 -c -O -o ./o/groups.o     ../groups.f
g95 -c -O -o ./o/grpline.o    ../grpline.f
g95 -c -O -o ./o/gyrate.o     ../gyrate.f
g95 -c -O -o ./o/hessian.o    ../hessian.f
g95 -c -O -o ./o/hessrgd.o    ../hessrgd.f
g95 -c -O -o ./o/hessrot.o    ../hessrot.f
g95 -c -O -o ./o/hybrid.o     ../hybrid.f
g95 -c -O -o ./o/image.o      ../image.f
g95 -c -O -o ./o/impose.o     ../impose.f
g95 -c -O -o ./o/induce.o     ../induce.f
g95 -c -O -o ./o/inertia.o    ../inertia.f
g95 -c -O -o ./o/initatom.o   ../initatom.f
g95 -c -O -o ./o/initial.o    ../initial.f
g95 -c -O -o ./o/initprm.o    ../initprm.f
g95 -c -O -o ./o/initres.o    ../initres.f
g95 -c -O -o ./o/initrot.o    ../initrot.f
g95 -c -O -o ./o/insert.o     ../insert.f
g95 -c -O -o ./o/intedit.o    ../intedit.f
g95 -c -O -o ./o/intxyz.o     ../intxyz.f
g95 -c -O -o ./o/invbeta.o    ../invbeta.f
g95 -c -O -o ./o/invert.o     ../invert.f
g95 -c -O -o ./o/jacobi.o     ../jacobi.f
g95 -c -O -o ./o/kangang.o    ../kangang.f
g95 -c -O -o ./o/kangle.o     ../kangle.f
g95 -c -O -o ./o/katom.o      ../katom.f
g95 -c -O -o ./o/kbond.o      ../kbond.f
g95 -c -O -o ./o/kcharge.o    ../kcharge.f
g95 -c -O -o ./o/kdipole.o    ../kdipole.f
g95 -c -O -o ./o/kewald.o     ../kewald.f
g95 -c -O -o ./o/kextra.o     ../kextra.f
g95 -c -O -o ./o/kgeom.o      ../kgeom.f
g95 -c -O -o ./o/kimprop.o    ../kimprop.f
g95 -c -O -o ./o/kimptor.o    ../kimptor.f
g95 -c -O -o ./o/kinetic.o    ../kinetic.f
g95 -c -O -o ./o/kmetal.o     ../kmetal.f
g95 -c -O -o ./o/kmpole.o     ../kmpole.f
g95 -c -O -o ./o/kopbend.o    ../kopbend.f
g95 -c -O -o ./o/kopdist.o    ../kopdist.f
g95 -c -O -o ./o/korbit.o     ../korbit.f
g95 -c -O -o ./o/kpitors.o    ../kpitors.f
g95 -c -O -o ./o/kpolar.o     ../kpolar.f
g95 -c -O -o ./o/ksolv.o      ../ksolv.f
g95 -c -O -o ./o/kstrbnd.o    ../kstrbnd.f
g95 -c -O -o ./o/kstrtor.o    ../kstrtor.f
g95 -c -O -o ./o/ktors.o      ../ktors.f
g95 -c -O -o ./o/ktortor.o    ../ktortor.f
g95 -c -O -o ./o/kurey.o      ../kurey.f
g95 -c -O -o ./o/kvdw.o       ../kvdw.f
g95 -c -O -o ./o/lattice.o    ../lattice.f
g95 -c -O -o ./o/lbfgs.o      ../lbfgs.f
g95 -c -O -o ./o/lights.o     ../lights.f
g95 -c -O -o ./o/makeint.o    ../makeint.f
g95 -c -O -o ./o/makeref.o    ../makeref.f
g95 -c -O -o ./o/makexyz.o    ../makexyz.f
g95 -c -O -o ./o/maxwell.o    ../maxwell.f
g95 -c -O -o ./o/mdinit.o     ../mdinit.f
g95 -c -O -o ./o/mdrest.o     ../mdrest.f
g95 -c -O -o ./o/mdsave.o     ../mdsave.f
g95 -c -O -o ./o/mdstat.o     ../mdstat.f
g95 -c -O -o ./o/mechanic.o   ../mechanic.f
g95 -c -O -o ./o/merge.o      ../merge.f
g95 -c -O -o ./o/minimize.o   ../minimize.f
g95 -c -O -o ./o/minirot.o    ../minirot.f
g95 -c -O -o ./o/minrigid.o   ../minrigid.f
g95 -c -O -o ./o/molecule.o   ../molecule.f
g95 -c -O -o ./o/molxyz.o     ../molxyz.f
g95 -c -O -o ./o/moments.o    ../moments.f
g95 -c -O -o ./o/monte.o      ../monte.f
g95 -c -O -o ./o/mutate.o     ../mutate.f
g95 -c -O -o ./o/nblist.o     ../nblist.f
g95 -c -O -o ./o/newton.o     ../newton.f
g95 -c -O -o ./o/newtrot.o    ../newtrot.f
g95 -c -O -o ./o/nextarg.o    ../nextarg.f
g95 -c -O -o ./o/nexttext.o   ../nexttext.f
g95 -c -O -o ./o/nose.o       ../nose.f
g95 -c -O -o ./o/nspline.o    ../nspline.f
g95 -c -O -o ./o/nucleic.o    ../nucleic.f
g95 -c -O -o ./o/number.o     ../number.f
g95 -c -O -o ./o/numeral.o    ../numeral.f
g95 -c -O -o ./o/numgrad.o    ../numgrad.f
g95 -c -O -o ./o/ocvm.o       ../ocvm.f
g95 -c -O -o ./o/openend.o    ../openend.f
g95 -c -O -o ./o/optimize.o   ../optimize.f
g95 -c -O -o ./o/optirot.o    ../optirot.f
g95 -c -O -o ./o/optrigid.o   ../optrigid.f
g95 -c -O -o ./o/optsave.o    ../optsave.f
g95 -c -O -o ./o/orbital.o    ../orbital.f
g95 -c -O -o ./o/orient.o     ../orient.f
g95 -c -O -o ./o/orthog.o     ../orthog.f
g95 -c -O -o ./o/overlap.o    ../overlap.f
g95 -c -O -o ./o/path.o       ../path.f
g95 -c -O -o ./o/pdbxyz.o     ../pdbxyz.f
g95 -c -O -o ./o/picalc.o     ../picalc.f
g95 -c -O -o ./o/pmestuff.o   ../pmestuff.f
g95 -c -O -o ./o/pmpb.o       ../pmpb.f
g95 -c -O -o ./o/polarize.o   ../polarize.f
g95 -c -O -o ./o/poledit.o    ../poledit.f
g95 -c -O -o ./o/polymer.o    ../polymer.f
g95 -c -O -o ./o/potential.o  ../potential.f
g95 -c -O -o ./o/precise.o    ../precise.f
g95 -c -O -o ./o/pressure.o   ../pressure.f
g95 -c -O -o ./o/prmedit.o    ../prmedit.f
g95 -c -O -o ./o/prmkey.o     ../prmkey.f
g95 -c -O -o ./o/promo.o      ../promo.f
g95 -c -O -o ./o/protein.o    ../protein.f
g95 -c -O -o ./o/prtdyn.o     ../prtdyn.f
g95 -c -O -o ./o/prterr.o     ../prterr.f
g95 -c -O -o ./o/prtint.o     ../prtint.f
g95 -c -O -o ./o/prtmol2.o    ../prtmol2.f
g95 -c -O -o ./o/prtpdb.o     ../prtpdb.f
g95 -c -O -o ./o/prtprm.o     ../prtprm.f
g95 -c -O -o ./o/prtseq.o     ../prtseq.f
g95 -c -O -o ./o/prtxyz.o     ../prtxyz.f
g95 -c -O -o ./o/pss.o        ../pss.f
g95 -c -O -o ./o/pssrigid.o   ../pssrigid.f
g95 -c -O -o ./o/pssrot.o     ../pssrot.f
g95 -c -O -o ./o/quatfit.o    ../quatfit.f
g95 -c -O -o ./o/radial.o     ../radial.f
g95 -c -O -o ./o/random.o     ../random.f
g95 -c -O -o ./o/rattle.o     ../rattle.f
g95 -c -O -o ./o/readdyn.o    ../readdyn.f
g95 -c -O -o ./o/readgau.o    ../readgau.f
g95 -c -O -o ./o/readint.o    ../readint.f
g95 -c -O -o ./o/readmol.o    ../readmol.f
g95 -c -O -o ./o/readmol2.o   ../readmol2.f
g95 -c -O -o ./o/readpdb.o    ../readpdb.f
g95 -c -O -o ./o/readprm.o    ../readprm.f
g95 -c -O -o ./o/readseq.o    ../readseq.f
g95 -c -O -o ./o/readxyz.o    ../readxyz.f
g95 -c -O -o ./o/replica.o    ../replica.f
g95 -c -O -o ./o/respa.o      ../respa.f
g95 -c -O -o ./o/rgdstep.o    ../rgdstep.f
g95 -c -O -o ./o/rings.o      ../rings.f
g95 -c -O -o ./o/rmsfit.o     ../rmsfit.f
g95 -c -O -o ./o/rotlist.o    ../rotlist.f
g95 -c -O -o ./o/rotpole.o    ../rotpole.f
g95 -c -O -o ./o/saddle.o     ../saddle.f
g95 -c -O -o ./o/scan.o       ../scan.f
g95 -c -O -o ./o/sdstep.o     ../sdstep.f
g95 -c -O -o ./o/search.o     ../search.f
g95 -c -O -o ./o/server.o     ../server.f
g95 -c -O -o ./o/shakeup.o    ../shakeup.f
g95 -c -O -o ./o/sigmoid.o    ../sigmoid.f
g95 -c -O -o ./o/sktstuff.o   ../sktstuff.f
g95 -c -O -o ./o/sniffer.o    ../sniffer.f
g95 -c -O -o ./o/sort.o       ../sort.f
g95 -c -O -o ./o/spacefill.o  ../spacefill.f
g95 -c -O -o ./o/spectrum.o   ../spectrum.f
g95 -c -O -o ./o/square.o     ../square.f
g95 -c -O -o ./o/suffix.o     ../suffix.f
g95 -c -O -o ./o/superpose.o  ../superpose.f
g95 -c -O -o ./o/surface.o    ../surface.f
g95 -c -O -o ./o/surfatom.o   ../surfatom.f
g95 -c -O -o ./o/switch.o     ../switch.f
g95 -c -O -o ./o/sybylxyz.o   ../sybylxyz.f
g95 -c -O -o ./o/temper.o     ../temper.f
g95 -c -O -o ./o/testgrad.o   ../testgrad.f
g95 -c -O -o ./o/testhess.o   ../testhess.f
g95 -c -O -o ./o/testpair.o   ../testpair.f
g95 -c -O -o ./o/testpol.o    ../testpol.f
g95 -c -O -o ./o/testrot.o    ../testrot.f
g95 -c -O -o ./o/timer.o      ../timer.f
g95 -c -O -o ./o/timerot.o    ../timerot.f
g95 -c -O -o ./o/tncg.o       ../tncg.f
g95 -c -O -o ./o/torphase.o   ../torphase.f
g95 -c -O -o ./o/torque.o     ../torque.f
g95 -c -O -o ./o/torsfit.o    ../torsfit.f
g95 -c -O -o ./o/torsions.o   ../torsions.f
g95 -c -O -o ./o/trimtext.o   ../trimtext.f
g95 -c -O -o ./o/unitcell.o   ../unitcell.f
g95 -c -O -o ./o/valence.o    ../valence.f
g95 -c -O -o ./o/verlet.o     ../verlet.f
g95 -c -O -o ./o/version.o    ../version.f
g95 -c -O -o ./o/vibbig.o     ../vibbig.f
g95 -c -O -o ./o/vibrate.o    ../vibrate.f
g95 -c -O -o ./o/vibrot.o     ../vibrot.f
g95 -c -O -o ./o/volume.o     ../volume.f
g95 -c -O -o ./o/xtalfit.o    ../xtalfit.f
g95 -c -O -o ./o/xtalmin.o    ../xtalmin.f
g95 -c -O -o ./o/xyzatm.o     ../xyzatm.f
g95 -c -O -o ./o/xyzedit.o    ../xyzedit.f
g95 -c -O -o ./o/xyzint.o     ../xyzint.f
g95 -c -O -o ./o/xyzpdb.o     ../xyzpdb.f
g95 -c -O -o ./o/xyzsybyl.o   ../xyzsybyl.f
g95 -c -O -o ./o/zatom.o      ../zatom.f