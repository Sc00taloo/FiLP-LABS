elemFreq(List, A, X) :- elemFreq(List, A, 0, X).
elemFreq([], _, Res, Res) :- !.
elemFreq([H|T], H, CurKol, X) :- NewKol is CurKol + 1, elemFreq(T, H, NewKol, X), !.
elemFreq([ _ |T], A, CurKol, X) :- elemFreq(T, A, CurKol, X), !.

concatList([], B, B) :- !.
concatList([H|T], X, [H|W]) :- concatList(T, X, W).

% „ƒ„p„}„„z „‰„p„ƒ„„„„z „„|„u„}„u„~„„ „ƒ„„y„ƒ„{„p
most_freqElem([H|T], X) :- most_freqElem([H|T], H, 1, X).
most_freqElem([], X, _, X) :- !.
most_freqElem([H|T], CurMaxEl, CurMaxFreq, X) :- elemFreq([H|T], H, X), (A > CurMaxFreq, NewMaxEl is H, NewMaxFreq is A; NewMaxEl is CurMaxEl, NewMaxFreq is CurMaxFreq), most_freqElem(T, NewMaxEl, NewMaxFreq, X), !.

filterByFreq(List, 3, X) :- filterByFreq(List, 3, [], X).
filterByFreq(List, A, [], _) :- most_freqElem(List, MF), elemFreq(List, MF, A1), A1 =< A, !, fail.
filterByFreq([], _, X, X) :- !.
filterByFreq([H|T], A, CurList, X) :- elemFreq([H|T], H, A1), (A1 > A, concatList(CurList, [H], NewList); NewList = CurList), filterByFreq(T, A, NewList, X), !.
