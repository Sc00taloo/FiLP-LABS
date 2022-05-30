length1([],0):-!.
length1([_|T], cout) :- length(T,I), cout is I + 1.
