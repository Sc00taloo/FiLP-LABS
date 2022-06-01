in_list([El|_],El).
in_list([_|T],El):-in_list(T,El).

task15 :-
    Dress = [_, _, _],
    in_list(Dress, [anya, _, _]),
    in_list(Dress, [valya, _, _]),
    in_list(Dress, [natasha, _, _]),
    in_list(Dress, [_, white, _]),
    in_list(Dress, [_, blue, _]),
    in_list(Dress, [_, green, _]),
    in_list(Dress, [_, _, white]),
    in_list(Dress, [_, _, blue]),
    in_list(Dress, [_, _, green]),
    not(in_list(Dress, [valya, W, W])),
    in_list(Dress, [natasha, _, green]),
    not(in_list(Dress, [valya, white, green])),
    not(in_list(Dress, [anya, _, green])),
    not(in_list(Dress, [valya, _, green])),
    not(in_list(Dress, [natasha, G, G])),
    write(Dress), !.
