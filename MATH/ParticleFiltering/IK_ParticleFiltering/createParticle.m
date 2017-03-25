%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: createParticle
% description:  create a particle of a chain (list of quaternions)
%               input: size(chain) = [joints number,4], samples number of
%               particles,gaussian parameters.
%               if equal, the particles = original chain. No sampling
%               output: particles
function p = createParticle(chain,samples,pg,equal)
w=ones(samples,1)./samples; %uniform weights
for i = 1:samples
    p(i,1).w = w(i); %weight
    p(i,1).g = pg; %gaussian ara tots iguals
    if(nargin<4)
        p(i,1).chain = chainQuTEMSampling(pg,chain);
    else
        p(i,1).chain = chain;
    end
end;
