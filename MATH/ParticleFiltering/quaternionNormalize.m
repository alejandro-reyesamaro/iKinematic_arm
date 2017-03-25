% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: quaternionNormalize
% description:  Compute quaternion normalized
% matrix
%               input: quaternion q1 
%               output: quaternion q1 normalized
function q=quaternionNormalize(q1)
n=quaternionNorm(q1);
q=[q1(:,1)./n(:,1),q1(:,2)./n(:,1),q1(:,3)./n(:,1),q1(:,4)./n(:,1)];
