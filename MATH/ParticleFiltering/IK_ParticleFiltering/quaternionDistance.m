% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: quaternionDistance
% description:  Compute approximate distance metric between two unit
%               quaternions [Kuffner ICRA 2004]
%               input: quaternions qDesination, qSamples.
%                      qDestination may not be unit
%               output: distance matrix
function d=quaternionDistance(qDestination,qSamples)
q2 = quaternionNormalize(qDestination);
q1 = ones(size(qSamples));
q=[q1(:,1).*q2(1),q1(:,2).*q2(2),q1(:,3).*q2(3),q1(:,4).*q2(4)];
lambda=quaternionInnerProduct(q,qSamples);
d=1-quaternionNorm(lambda);

%TODO: Per ara no tenim en compte els pesos.
