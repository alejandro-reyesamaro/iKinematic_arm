%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 29/03/2010
% function: PF process
% description:  pik process PF
%               input: cOrigin, goal, 
%                                               
%               output: particles and best index
function [p,I] = PF(goal,particles, S)%,image)
wSum = 0;
resampling = 0;
for i= 1:size(particles,1)
    %sampling
    for j  = 1:size(particles(i).chain,1)
         p(i,1).chain(j,1) = chainQuTEMSampling(particles(i).g,particles(i).chain(j)); %TODO: alerta amb els paràmetres
    end
    %compute weight
    p(i,1).g = particles(i).g;
    weight = weightFunction(p(i,1).chain,goal, S);%,image);    
    p(i,1).w = particles(i).w*weight;
    %weights cumsum
    wSum = wSum+p(i,1).w;
    %computing resamplig condition
    resampling = resampling+p(i,1).w^2;
end

%normalize weights
for i= 1:size(p)
    p(i,1).w=p(i,1).w/wSum;
end

%best chain
max = 0;
imax = 1;
for i= 1:size(p)
%     ww = particles(i).w
    if(p(i).w>max)
        max = p(i).w;
        imax = i;
    end
end
I = imax;

%if necessary, resampling
%Effective Sample Size, Tutorial PF, 15 year later
% if((1/resampling)<=(size(p,1)/2))
%     'resampling'
    p = remostrejar(p);
% end

    
