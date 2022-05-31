getMinList([Head | Tail], Min) :- getMinList([Head | Tail], Head, Min).
getMinList([], Min, Min) :- !.
getMinList([Head | Tail], CurMin, Min) :- (Head < CurMin, NewMin is Head; NewMin is CurMin), getMinList(Tail, NewMin, Min), !.
