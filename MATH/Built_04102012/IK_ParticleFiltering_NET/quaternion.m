% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: quaternion
% description:  create a quaternion from input values
%               a quaternion is defined by scalar par (s) and vector part (x,y,z)
%               input: 4 values(w,x,y,z)
%               output: return quaternion

function [q]=quaternion(s,p)
q=[s,p];
%TODO: Tal vegada s'hauria de fer un get i set per quaternion. Per ara ho
%deixam així.

