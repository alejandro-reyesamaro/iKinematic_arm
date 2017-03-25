% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 15/03/2010
% function: main
% description: Implement a vector with quaternions. IK with montecarlo.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%     Sampling QuTEM, end-effector distance + image distance
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
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
%chainOrigin =createChain([0,0.6,0;0.4,0.4,0; 0.6, 0, 0]);
chainOrigin =createChain([0,1,0;0.6,-0.7,0; 0.4, 0.7, 0]);
goal = [1.2,1.2,0];
g = [];
best = [];
%-----------------------------------------------------------------
%obstacle definition ---------------------------------------------

for i=1:5
    cadena = chain2positions(chainOrigin);
    %create particles
    particles = createParticle(chainOrigin,samples,parametros_gausiana);
    % pik
    chainResult = pik(chainOrigin,goal,particles, 2);%,image);%,chainDestination); 
    goalResult = chainEndEffectorPosition(chainResult.chain);
    g = [g, goal'];
    goal = [goal(1)+ 0.05, goal(2)- 0.1, 0];    
    best = [best chainResult];
    chainOrigin = chainResult.chain;
end
pause;
close;

for i=1:5
    goal = g(i);
    rectangle('Position',[g(1,i)-0.05,g(2,i)-0.05,0.3,0.1],'FaceColor','k');
    hold on;
    plotParticles(best(i),'r');
    hold on;
end

