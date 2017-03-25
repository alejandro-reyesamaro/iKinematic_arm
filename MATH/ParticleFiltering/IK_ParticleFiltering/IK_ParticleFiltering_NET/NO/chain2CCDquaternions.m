%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 12/04/2010
% function: chain2CCDquaternions
% http://www.tar.hu/gamealgorithms/ch15lev1sec9.html
% description:  Compute the quaternions rotations for CCD
%               input: chain, goal 
%               output: quaterions
function q= chain2CCDquaternions(chain,goal)
%chain copy
c = chain;
q = zeros(size(c,1),4);
i = size(c,1);
while i>0
    p = chain2positions(c);
    ee = chainEndEffectorPosition(c);
    %compute vector v1 from bone pivot to effector
    v1 = ee-p(i,:);
%     v1 = p(i,:)-ee;
    %compute vector V2 from bone pivot to goal
    v2 = goal-p(i,:);
%     v2 = p(i,:)-goal;
    c(i).q = vectors2quaternion(v1,v2);
    q(i,:) = c(i).q;
    i = i-1;
%     plotChain3D(c,'r');
%     i
%     p = chain2positions(c)
%     pause(15);
end

% 
% p = chain2positions(chain);
% for i = 1:size(chain)
% %     q(i,:) = quaternionProduct(point2quaternion(chain(i).v),point2quaternion(goal-p(i,:)));
%     q(i,:) = vectors2quaternion(chain(i).v,goal-p(i,:));
% end
% % q = quaternionNormalize(q);
