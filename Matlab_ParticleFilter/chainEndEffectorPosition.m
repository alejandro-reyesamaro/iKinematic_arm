% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 17/03/2010
% function: chainEndEffectorPosition
% description:  Compute the end-effector position of a lineal chain
%               input: matrix of chain's
%               output: matrix of ee positions size = x, y ,z. x = 1 
%               y= coordinates per position; z = number of ee
function [ee]=chainEndEffectorPosition(chain)
for j = 1:size(chain,3)
    p =[0 0 0];
    for i = 1:size(chain,1)
        p=p+quaternionRotation(chain(i).v,chain(i).q);
    end
    ee(j,:) = p;
end


