% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 25/03/2010
% function: chainQuTEMReSampling [15 years later PF]
% description:  QuTem resampling the quaternion of lineal chain
%               input: s,s1,s2,s3 (QuTEM parameters)numbers of samples, original chain
%               output: cs (samples is number of matrix) 3D matrix
%                       size(cs) =[size(chain,1),size(chain,2),samples]
%                       quaternions are normalized
function res=remostrejar(particles)
baseWeight = 1/size(particles,1);
res = particles;
for i = 1:size(res,1)
    r = rand();
    if rand == 1
        r = rand();
    end
    base = 0;
    count = 0;
%     r
    while(r>base)
        count = count+1;
        base = base+particles(count).w;
    end
%     base=base
    res(i,1).chain = particles(count,1).chain;
    res(i,1).w = baseWeight;
end