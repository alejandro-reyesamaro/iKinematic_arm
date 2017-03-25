%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 12/04/2010
% function: Cyclic Coordinate Descent and QuTEM Sampling
% description:  CCD plus PF
%               input: goal, chain,gaussian parameters, f, epsilon
%               output: chain
function c = chainCCDQuTemSamplig(goal,g,chain,f,epsilon)
%compute joints quaternion rotation for CCD. From quaternion of joint to vector joint
%position-->goal
q = chain2CCDquaternions(chain,goal);
for i = 1:size(chain)
%     qslerp(i,:)=slerp(chain(i).q,q(i,:),f,epsilon);
%     qsampling(i,:) = quaternionQuTEMSampling(qslerp(i,:),g,1,'CCD');
%      r(i,:) = quaternionProduct(qsampling(i,:),qslerp(i,:));

    r(i,:) = quaternionProduct(chain(i).q,q(i,:));
    c(i,1).q = r(i,:);
    c(i,1).v = chain(i).v;
end
%TODO: Que funcioni amb matrius
