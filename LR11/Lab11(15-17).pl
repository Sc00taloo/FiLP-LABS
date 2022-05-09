% 15
min(X,Y,X):- X < Y,!.
min(_,Y,Y).
mincifr(0,9):- !.
mincifr(N,Y):-N1 is N div 10, mincifr(N1,Y1),Cifr is N mod 10,min(Cifr,Y1,Y).

% 16
min_cifr(N,M):- min_cifr(N,M,9).
min_cifr(0,X,X):- !.
min_cifr(N,X,C):- Cifr is N mod 10,
    NewN is N div 10,
    min(Cifr,C,Newmin),
    min_cifr(NewN,X,Newmin).

%17
coutthree(0,0):- !.
coutthree(N,Y):- N1 is N div 10,Cifr is N mod 10, coutthree(N1,Y1), (Cifr < 3, Y is Y1 + 1; Y is Y1).
