in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

task14 :-
    Hair = [_, _, _],
    in_list(Hair, [belokurov, _]),
    in_list(Hair,[chernov, _]),
    in_list(Hair,[rizhov, _]),
    in_list(Hair,[_, redhead]),
    in_list(Hair,[_, blond]),
    in_list(Hair,[_, brunette]),
    not(in_list(Hair,[belokurov, blond])),
    not(in_list(Hair,[belokurov, brunette])),
    not(in_list(Hair,[chernov, brunette])),
    not(in_list(Hair,[rizhov, redhead])),
    write(Hair), !.


