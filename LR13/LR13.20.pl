in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

after(X, Y, [X|T]) :- in_list(T, Y).
after(X, Y, [_|T]) :- after(X, Y, T).


task20 :-
    Teachers = [_, _, _],
    in_list(Teachers, [morozov, _, _]),
    in_list(Teachers, [vasilev, _, _]),
    in_list(Teachers, [tokarev, _, _]),

    (in_list(Teachers, [_, history, _]); in_list(Teachers, [_, _, history])),
    (in_list(Teachers, [_, math, _]); in_list(Teachers, [_, _, math])),
    (in_list(Teachers, [_, biology, _]); in_list(Teachers, [_, _, biology])),
    (in_list(Teachers, [_, geography, _]); in_list(Teachers, [_, _, geography])),
    (in_list(Teachers, [_, english, _]); in_list(Teachers, [_, _, english])),
    (in_list(Teachers, [_, french, _]); in_list(Teachers, [_, _, french])),

    not(in_list(Teachers, [_, geography, french])),
    not(in_list(Teachers, [_, french, geography])),
    not(in_list(Teachers, [_, biology, math])),
    not(in_list(Teachers, [_, math, biology])),

    after([_, math, _], [_, biology, _], Teachers),
    after([morozov, _, _], [vasilev, _, _], Teachers),
    after([morozov, _, _], [tokarev, _, _], Teachers),

    not(in_list(Teachers, [tokarev, biology, _])),
    not(in_list(Teachers, [tokarev, _, biology])),
    not(in_list(Teachers, [tokarev, french, _])),
    not(in_list(Teachers, [tokarev, _, french])),
    not(in_list(Teachers, [_, biology, french])),
    not(in_list(Teachers, [_, french, biology])),
    not(in_list(Teachers, [morozov, math, _])),
    not(in_list(Teachers, [morozov, _, math])),
    not(in_list(Teachers, [morozov, english, _])),
    not(in_list(Teachers, [morozov, _, english])),
    not(in_list(Teachers, [_, math, english])),
    not(in_list(Teachers, [_, english, math])),

    write(Teachers), !.
