join([], X, X).
join([H|T], Z, [H|W]) :- join(T, Z, W).

shift_left(X, 0, X) :- !.
shift_left([H|T], N, X) :- N1 is N - 1, join(T, [H], NewList), shift_left(NewList, N1, X),!.

shift_left_1([H|T], X) :- shift_left([H|T], 1, X).
