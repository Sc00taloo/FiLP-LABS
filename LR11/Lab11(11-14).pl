man(mihail).
man(petrov).
man(fyodor).
man(kirill).
man(gleb).
man(kolya).
man(maksim).
man(efrimof).
man(joni).
man(ivan).

woman(anya).
woman(galya).
woman(vera).
woman(polina).
woman(milana).
woman(kristina).
woman(jinjer).
woman(nina).
woman(alina).
woman(rosa).
woman(rina).


parent(mihail,maksim).
parent(petrov,alina).
parent(petrov,nina).
parent(fyodor,kolya).
parent(fyodor,jinjer).
parent(kirill,gleb).

parent(anya,maksim).
parent(galya,alina).
parent(vera,nina).
parent(polina,kolya).
parent(milana,jinjer).
parent(kristina,gleb).


parent(maksim,efrimof).
parent(maksim,joni).
parent(kolya,ivan).
parent(gleb,rosa).
parent(gleb,rina).

parent(alina,efrimof).
parent(alina,joni).
parent(nina,ivan).
parent(jinjer,rosa).
parent(jinjer,rina).

%11
proverka(X,Y):-parent(X,Y).
daughter(X,Y):- proverka(Y,X),woman(X).
daughter(X):- daughter(Y,X),write(Y),nl.

% 12
husband(X,Y):- parent(X,Z),parent(Y,Z),man(Y).
husband(X):-husband(Y,X),write(Y),!.

% 13
grand_so(X,Y):-parent(Y,Z),parent(Z,X),man(X).
grand_sons(X):-grand_so(Y,X),write(Y),nl,fail.

% 14
grand_da(X,Y):-parent(Y,Z),parent(Z,X),woman(X); parent(X,Z),parent(Z,Y),woman(Y).
grand_ma_da(X,Y):- grand_da(X,Y),woman(Y),woman(X).
