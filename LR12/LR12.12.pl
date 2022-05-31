simple(1) :- !, fail.
simple(X) :- simple(X, 2).
simple(X, X) :- !.
simple(X, I) :- 0 =:= (X mod I), !, fail; I1 is I + 1, simple(X, I1), !.

nod(A, 0, A) :- !.
nod(A, B, X) :- C is A mod B, nod(B, C, X).

sumProsDel(0, 0) :- !.
sumProsDel(X, Res) :- X1 is X div 10, sumProsDel(X1, Res1), Dig is X mod 10, (simple(Dig), Res is Res1 + Dig; Res is Res1), !.

task12(X, Kol) :- task12(X, X, Kol).
task12(_, 2, 0) :- !.
task12(X, I, Kol) :- I1 is I - 1, task12(X, I1, Kol1), sumProsDel(X, Sum), nod(X, I, Res1), nod(Sum, I, Res2) ,0 =\= (X mod I), 1 =\= Res1, 1 =:= Res2, Kol is Kol1 + 1; Kol is Kol1, !.