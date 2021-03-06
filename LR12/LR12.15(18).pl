join([], X, X).
join([H|T], Z, [H|W]) :- join(T, Z, W).

get_before([], _, X, X) :- !.
get_before([H|_], H, X, X) :- !.
get_before([H|T], Z, CurList, X) :- join(CurList, [H], NewList), get_before(T, Z, NewList, X), !.
get_before([H|T], Z, X) :- get_before([H|T], Z, [], X).
