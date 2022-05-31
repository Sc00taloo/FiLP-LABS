list_avg(List, X) :- list_avg(List, 0, 0, X).
list_avg([], CurSum, CurCnt, X) :- X is CurSum div CurCnt.
list_avg([H|T], CurSum, CurCnt, X) :- NewSum is CurSum + H, NewCnt is CurCnt + 1, list_avg(T, NewSum, NewCnt, X), !.
