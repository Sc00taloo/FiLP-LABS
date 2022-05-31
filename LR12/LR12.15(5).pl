getMinList([H|T], Min) :- getMinList([H|T], H, Min).
getMinList([], Min, Min) :- !.
getMinList([H|T], CurMin, Min) :- (H< CurMin, NewMin is H; NewMin is CurMin), getMinList(T, NewMin, Min), !.
