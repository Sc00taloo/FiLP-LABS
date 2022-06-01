in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

task16 :-
    Factory = [_, _, _, _],
    in_list(Factory, [borisov, _, 1, _]),
    in_list(Factory, [ivanov, _, _, _]),
    in_list(Factory, [semenov, _, _, 2]),
    in_list(Factory, [_, slesar, 0, 0]),
    in_list(Factory, [_, tokar, _, 1]),
    in_list(Factory, [_, svarshik, _, _]),
    in_list(Factory, [Friend1, slesar, _, _]),
    in_list(Factory, [Friend2, tokar, _, _]),
    in_list(Factory, [Friend3, svarshik, _, _]),
    write('slesar is '), write(Friend1), nl, write('tokar is '), write(Friend2), nl, write('svarshick is '), write(Friend3), !.
