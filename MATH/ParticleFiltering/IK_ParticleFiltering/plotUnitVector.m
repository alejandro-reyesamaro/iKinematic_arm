% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: plotUnitVector
% description:  plot unit vector 3d, with reference system
%               input: theta, v=(x,y,z)
%               output: plot
function h=plotUnitVector(x,y,z)
h=plot3([x,0],[y,0],[z,0]);
grid on;
%TODO: Valid for matrix