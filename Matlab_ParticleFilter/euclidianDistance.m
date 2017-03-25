%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 29/03/2010
% function: euclidianDistance
% description:  between two 3D points
%               input: cOrigin, goal
%               output: particle
function d = euclidianDistance(p1,p2)
d=norm(p1-p2);