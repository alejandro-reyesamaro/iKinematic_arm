% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 15/03/2010
% function: quaternionRotation
% description:  rotation using quaternions
%               q = rpr-1
%               input: point to rotate (p), vector quaternion rotation (r)
%               output: return point rotate result.
function [q]=quaternionRotation(vector,quaternion)
%Create vector of quaternion point
q = ones(size(quaternion));
q = [0,q(:,2).*vector(1),q(:,3).*vector(2),q(:,4).*vector(3)];
q=quaternionProduct(quaternion,q);
q=quaternionProduct(q,quaternionConjugate(quaternion));
q=[q(:,2) q(:,3) q(:,4)];
%--------------------------------------------------------------------------
