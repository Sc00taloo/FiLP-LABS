fact(N, X) :- fact(N, X, 0, 1).
fact(N, X, N, X) :- !.
fact(N, X, N1, Res) :- N2 is N1 + 1, X2 is N2 * Res, fact(N, X, N2, X2).

digitSum(X, Sum) :- digitSum(X, Sum, 0).
digitSum(0, Sum, Sum) :- !.
digitSum(X, Sum, CurSum) :- Dig is X mod 10, fact(Dig, Dig1), NewSum is CurSum + Dig1, X1 is X div 10, digitSum(X1, NewSum, Sum).

is_WowNumber(X) :- digitSum(X, FactSum), X = FactSum.

task13(X) :- task13(1000, 0, X).
task13(2, X, X) :- !.
task13(CurN, CurSum, X) :- NewN is CurN - 1, (is_WowNumber(CurN), NewSum is CurSum + CurN; NewSum is CurSum), task13(NewN, NewSum, X), !.