in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

task18 :-
    Professions = [_, _, _, _],
    in_list(Professions, [voronov, _]),
    in_list(Professions, [pavlov, _]),
    in_list(Professions, [levizkiy, _]),
    in_list(Professions, [saharov, _]),
    in_list(Professions, [_, dancer]),
    in_list(Professions, [_, painter]),
    in_list(Professions, [_, singer]),
    in_list(Professions, [_, writer]),
    not(in_list(Professions, [voronov, singer])),
    not(in_list(Professions, [levizkiy, singer])),
    not(in_list(Professions, [pavlov, painter])),
    not(in_list(Professions, [pavlov, writer])),
    not(in_list(Professions, [saharov, writer])),
    not(in_list(Professions, [voronov, writer])),
    write(Professions), !.
