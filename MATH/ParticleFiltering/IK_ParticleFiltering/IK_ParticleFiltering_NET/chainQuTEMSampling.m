% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 31/03/2010
% function: chainQuTEMSampling [Johnson]
% description:  QuTem sampling the quaternion from chain
%               input: g (QuTEM parameters), original chain
%               output: chain
function c = chainQuTEMSampling(g,chain)
particles = quaternionQuTEMSampling(chain,g,size(chain,1));
for i=1:size(chain,1)
    c(i,1).q = particles(i,:);
    c(i,1).v = chain(i).v;
end
