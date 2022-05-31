getLocalMax([Head | Tail], Index) :- getLocalMax([Head | Tail], 1, Index).
getLocalMax([Prev, Current, Next | _], Index, Index) :- Current > Prev, Current > Next.
getLocalMax([_ | Tail], I, Index) :- I1 is I + 1, getLocalMax(Tail, I1, Index), !.
