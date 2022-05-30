simple(1) :- !, fail.
simple(X) :- simple(X, 2).
simple(X, X) :- !.
simple(X, I) :- 0 =:= (X mod I), !, fail; I1 is I + 1, simple(X, I1), !.

% 11.1
notSimDelSum_Up(X, Res) :- notSimDelSum_Up(X, X, Res).
notSimDelSum_Up(_, 2, 1) :- !.
notSimDelSum_Up(X, I, Res) :- I1 is I - 1, notSimDelSum_Up(X, I1, Res1), (not(simple(I)), 0 =:= (X mod I), Res is Res1 + I;Res is Res1), !.

% 11.2
notSimDelSum_Down(X, Res) :- notSimDelSum_Down(X, X, 1, Res).
notSimDelSum_Down(_, 2, Res, Res) :- !.
notSimDelSum_Down(X, I, CurSum, Res) :- I1 is I - 1, (not(simple(I)), 0 =:= (X mod I), !), NewSum is CurSum + I, notSimDelSum_Down(X, I1, NewSum, Res); I2 is I - 1, notSimDelSum_Down(X, I2, CurSum, Res).
