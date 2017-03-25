% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 29/03/2010
% function: plotParticles
% description:  Plot particles. 
%               input: particles et colors
%               output: plot
function h=plotParticles(particles,color)
for i=1:size(particles,1);
    chain = particles(i).chain;
    hold on;
    plotChain3D(chain,color);
    hold off;
end