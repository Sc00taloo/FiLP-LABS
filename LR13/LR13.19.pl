in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

task19:-Friends=[_,_,_],
	in_list(Friends,[michael,_,_,_]),
	in_list(Friends,[saimon,_,_,_]),
	in_list(Friends,[richard,_,_,What]),
	in_list(Friends,[_,1,_,_]),
	in_list(Friends,[_,2,_,_]),
	in_list(Friends,[_,3,_,_]),
	in_list(Friends,[_,_,american,_]),
	in_list(Friends,[_,_,israeli,_]),
	in_list(Friends,[Who,_,australian,_]),
	in_list(Friends,[_,_,_,kriket]),
	in_list(Friends,[_,_,_,basketboll]),
	in_list(Friends,[_,_,_,tenis]),
	in_list(Friends,[michael,_,_,basketboll]),
	not(in_list(Friends,[michael,_,american,_])),
	in_list(Friends,[saimon,_,israeli,_]),
	not(in_list(Friends,[saimon,_,_,tenis])),
	in_list(Friends,[_,1,_,kriket]),
	write('australian is '),write(Who),nl,write('richard is '),write(What),!.
