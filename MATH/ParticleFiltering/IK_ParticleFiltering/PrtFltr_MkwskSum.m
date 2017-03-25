function [chainResult, chainResult_points, it, distance] = PrtFltr_MkwskSum(max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj, samples, media_gausiana)
% Esta funcion es la que engloba los algoritmos de Filtro de Particulas
% y Suma de Minkowski. Como parámetros se le pasa:
% max_iter: Maximo de iteraciones que realizara el filtraje
% epsilon:  tolerancia de cercanía con el objetivo
% S:        el sistema de obstaculos
% x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
% y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
% obj:      objetivo intermedio 
% samples:  cantidad de particulas que se generaran
% media_gausiana: media para la generación de particulas (0.03)
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
% coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
% inverso a a las manesillas del reloj

%creating the obstacles
n = max(size(obst_ranks));
S = [];
a = 1;
b = 1;
for i = 1:n
	b = obst_ranks(i);
    t = 1;
    for j = a:b
        p.x = x_obst(j);
        p.y = y_obst(j);
        O.ptos(t) = p;
        t = t + 1;
    end
    S = [S O];
    a = b + 1;
end

%global parameters
rotar_en_x=0;
rotar_en_y=0;
rotar_en_z=1; %rotacion solo en el eje z
parametros_gausiana = setGaussianParameters(media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);

%chain definition
%chainOrigin =createChain([0,1,0;1,0,0]);
chaint = positions2chain(x_axis, y_axis);
chainOrigin = createChain(chaint);
%cadena = chain2positions(chainOrigin);

goal = [obj(1), obj(2), 0];
%create particles
particles = createParticle(chainOrigin,samples,parametros_gausiana);
% pik
[chainResult, it, distance] = pik(max_iter, epsilon, chainOrigin,goal,particles,S);
chainResult_points = chain2positions(chainResult.chain);

