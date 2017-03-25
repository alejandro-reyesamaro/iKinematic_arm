% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 17/03/2010
% function: chain2position
% description:  Compute the absolute joint positions of chain
%               input: chain, joint quaternions
%               output: positions
function posiciones=chain2positions(chain)
posiciones=[0,0,0];
for i=1:size(chain,1)
    p1 = quaternionRotation(chain(i).v,chain(i).q);
    posiciones=[posiciones;posiciones(i,:)+p1];
end
%TODO: Valid for matrix