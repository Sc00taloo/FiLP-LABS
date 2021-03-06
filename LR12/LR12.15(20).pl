join([], X, X).
join([H|T], Z, [H|W]) :- join(T, Z, W).

getMinList([H|T], Min) :- getMinList([H|T], H, Min).
getMinList([], Min, Min) :- !.
getMinList([H|T], CurMin, Min) :- (H< CurMin, NewMin is H; NewMin is CurMin), getMinList(T, NewMin, Min), !.

getMaxList([], X, X) :- !.
getMaxList([H|T], CurrentMax, X) :- (H > CurrentMax, NewMax is H; NewMax is CurrentMax), getMaxList(T, NewMax, X), !.
getMaxList([H|T], X) :- getMaxList([H|T], H, X).

contains([H|_], H) :- !.
contains([], _) :- !, fail.
contains([_|T], X) :- contains(T, X), !.

build_missing(_, Min, Min, X, X) :- !.
build_missing(OrigList, Min, I, AccumList, X) :- NewI is I - 1, contains(OrigList, I), join([], AccumList, NewList); join([I], AccumList, NewList), build_missing(OrigList, Min, NewI, NewList, X), !.
build_missing(OrigList, X) :- getMinList(OrigList, Min), getMaxList(OrigList, Max), build_missing(OrigList, Min, Max, [], X).
