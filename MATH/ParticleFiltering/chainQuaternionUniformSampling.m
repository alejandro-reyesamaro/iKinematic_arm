% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: chainQuaternionUniformSampling [Kafnet ICRA 2004]
% description:  Uniform sampling the quaternion of lineal chain
%               input: numbers of samples, original chain
%               output: cs (samples is number of matrix) 3D matrix
%                       size(cs) =[size(chain,1),size(chain,2),samples]
function [cs]=chainQuaternionUniformSampling(samples,chain)
cs = [];
for i=1:samples
    cs= cat(3,cs,quaternionUniformSampling(size(chain,1)));
end
