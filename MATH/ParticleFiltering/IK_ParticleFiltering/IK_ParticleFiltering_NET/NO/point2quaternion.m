% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: point2quaternion
% description:  create a quaternion from input values
%               a quaternion is defined by scalar par (w) and vector part
%               (x,y,z)
%               input: p [x,y,z]. size(p) = [number points, 3]
%               output: return quaternion
function [q]=point2quaternion(p)
q=quaternion(zeros(size(p,1),1),p);