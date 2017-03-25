% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 15/03/2010
% function: quaternionConjugate
% description: 
%               input: quaternion p
%               output: return conj(p)
function [qc]=quaternionConjugate(q)
qc=[q(:,1),-q(:,2),-q(:,3),-q(:,4)];

