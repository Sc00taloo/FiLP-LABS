fact(0,F,F):-!.
fact(I,F,Fact):-Fact1 is Fact * I, I1 is I - 1, fact(I1,F,Fact1).
fact(N,X):-fact(N,X,1).

psfdin(0,X,X):-!.
psfdin(N,X,Sum):-N1 is N div 10, Dig is N mod 10, fact(Dig,S), Sum1 is Sum + S, psfdin(N1,X,Sum1).

is_WowNumber(X):-psfdin(X,Sum,0), X is Sum.

task13(X):-task13(10000,X,0).
task13(2,X,X):-!.
task13(N,X,Sum):- is_WowNumber(N), Sum1 is Sum + N, N1 is N - 1, task13(N1,X,Sum1), !.
task13(N,X,Sum):-N1 is N - 1, task13(N1,X,Sum).
