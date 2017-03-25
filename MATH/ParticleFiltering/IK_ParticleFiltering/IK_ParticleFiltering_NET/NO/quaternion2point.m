% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: quaternion2point
% description:  create a point from quaternion
%               input: vector of quaternions
%               output: vector of points
function [p]=quaternion2point(q)
p=q(:,2:4);

