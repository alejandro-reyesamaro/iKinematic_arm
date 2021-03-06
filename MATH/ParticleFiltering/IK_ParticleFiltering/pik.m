%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: createParticle
% description:  pik process PF
%               input: cOrigin, goal, particles, 
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 
%               output: particle
function [chainResult, it, distance] = pik(max_iter, epsilon, chain,goal,particles, S)%,image) %,chainDestination)
%chainResult = chain;
chainResult = particles(1);
ee = chainEndEffectorPosition(chainResult.chain);
it = 0;
I = 1;
while(it < max_iter && euclidianDistance(ee,goal) > epsilon)
    [particles,I] = PF(goal,particles, S);
    ee = chainEndEffectorPosition(particles(I).chain);
    chainResult = particles(I);
    it = it + 1;    
end
distance = euclidianDistance(ee,goal);

