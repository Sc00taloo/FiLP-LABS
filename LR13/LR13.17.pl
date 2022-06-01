in_list([],_):-fail.
in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

right(_,_,[]):-fail.
right(A,B,[A|[B|_]]).
right(A,B,[_|T]):-right(A,B,T).

left(_,_,[]):-fail.
left(A,B,[B,[[B|A]|_]]).
left(A,B,[_|T]):-left(A,B,T).

next_to(A,B,T):-right(A,B,T).
next_to(A,B,T):-left(A,B,T).


task17 :-
        Drinks=[_,_,_,_],
	in_list(Drinks,[bottle,_]),
	in_list(Drinks,[glass,_]),
	in_list(Drinks,[jug,_]),
	in_list(Drinks,[pot,_]),
	in_list(Drinks,[_,water]),
	in_list(Drinks,[_,milk]),
	in_list(Drinks,[_,lemonade]),
	in_list(Drinks,[_,kvas]),
	not(in_list(Drinks,[bottle,milk])),
	not(in_list(Drinks,[bottle,water])),
	not(in_list(Drinks,[pot,water])),
	not(in_list(Drinks,[pot,lemonade])),
	right([jug,_],[_,lemonade],Drinks),
	right([_,lemonade],[_,kvas],Drinks),
	next_to([glass,_],[pot,_],Drinks),
	next_to([glass,_],[_,milk],Drinks),
	write(Drinks),!.
