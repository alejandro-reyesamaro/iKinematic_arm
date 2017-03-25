clear;
clc;
close all;
%global parameters
media_gausiana=0.03; %media gausiana
rotar_en_x=0;
rotar_en_y=0;
rotar_en_z=1; %rotacion solo en el eje z
samples=25; % numero de particulas
parametros_gausiana = setGaussianParameters(media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);

%chain definition  -----------------------------------------------
%chainOrigin =createChain([0,1,0;1,0,0]);
chainOrigin =createChain([0,0.6,0;0.4,0.4,0; 0.6, 0, 0]);
goal = [1.2,0.4,0];
g = [];
best = [];
%-----------------------------------------------------------------

%obstacle definition ---------------------------------------------
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 
p.x = 0.8; p.y = 0.6; O1.ptos(1) = p;
p.x = 1.3; p.y = 0.6; O1.ptos(2) = p;
p.x = 1.3; p.y = 0.9; O1.ptos(3) = p;
p.x = 0.8; p.y = 0.9; O1.ptos(4) = p;
S = [O1];
%-----------------------------------------------------------------


cadena = chain2positions(chainOrigin);
%create particles
particles = createParticle(chainOrigin,samples,parametros_gausiana);
% pik
chainResult = pik(chainOrigin,goal,particles,S);%,image);%,chainDestination); 
goalResult = chainEndEffectorPosition(chainResult.chain);
%g = [g, goal'];
goal = [goal(1)+ 0.05, goal(2)- 0.1, 0];

%best = [best chainResult];
%chainOrigin = chainResult.chain;
