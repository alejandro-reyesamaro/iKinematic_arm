% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: pointDistance
% description:  distance between 2 points
%               input: p1,p2 vector of points
%               output: vector of distance
function d=pointDistance(p1,p2)
d = sqrt((p1(:,1)-p2(:,1)).^2.+(p1(:,2)-p2(:,2)).^2.+(p1(:,3)-p2(:,3)).^2);
