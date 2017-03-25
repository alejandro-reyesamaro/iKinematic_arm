% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: quaternionNorm
% description:  Compute quaternion norm
% matrix
%               input: quaternion q
%               output: quaternion q norm
function n=quaternionNorm(q)
n = sqrt(q(:,1).^2.+q(:,2).^2.+q(:,3).^2.+q(:,4).^2);
