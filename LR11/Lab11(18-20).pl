%18
coutthree(N,X):- coutthree(N,X,1).
coutthree(N,X,Count):- X > 0,!,X1 is X div 10,Cifr is X mod 10,
    (Cifr < 3,Count1 is Count + 1; Count1 is Count),countpro(X1,N,Count1).
countpro(_,N,Z):- N is Z.

%19
fib(1,1):-!.
fib(2,1):-!.
fib(N,X):-N1 is N-1,N2 is N-2,fib(N1,X1),fib(N2,X2),X is X1+X2.

% 20
fibn(N,X):-fibn(N,X,1,1,2).
fibn(N,X,_,X,N):-!.
fibn(N,X,F1,F2,C):-NewC is C+1,NewF1 is F2,NewF2 is F2+F1,
    fibn(N,X,NewF1,NewF2,NewC).
