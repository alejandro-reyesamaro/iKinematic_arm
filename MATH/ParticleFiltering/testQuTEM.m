% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 25/03/2010
% function: Test to draw a set of samples of QuTEM
% description: Sampling samples of QuTEM, and draw
function testQuTEM(m,s,s1,s2,s3,samples)
p = quaternionQuTEMSampling(m,s,s1,s2,s3,samples);
%p=quaternionUniformSampling(samples);
% for i = 1:samples
%     p(i,:)=quaternionNormalize(p(i,:));
% end
p=quaternion2point(p);
for i = 1:samples
    p(i,:)=p(i,:)/norm(p(i,:));
end
plotPoint3D(p);
norm(p(1,:))
