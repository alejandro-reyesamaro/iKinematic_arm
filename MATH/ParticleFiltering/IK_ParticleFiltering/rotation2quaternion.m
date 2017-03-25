% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: rotation2quaternion
% description:  rotation of theta angle through unit vector(x,y,z)
%               input: theta, u=(x,y,z)
%               output: quaternion
function [q]=rotation2quaternion(theta,x,y,z)
%theta should divide 2, because the negative quaternion it is the same
%rotation of the possitive quaternion.
q=quaternion(cos(theta/2),x*sin(theta/2),y*sin(theta/2),z*sin(theta/2));
%TODO: Valid for matrix