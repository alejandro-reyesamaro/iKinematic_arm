% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 15/03/2010
% function: quaternionUniformSampling [Kafnet ICRA 2004]
% description:  Uniform sampling of unit quaternions
%               input: samples = number of samples
%               output: samples quaternion matrix  (samples is number of rows)
function [q]=quaternionUniformSampling(samples)
n= rand(samples,1);
s1=sqrt(1-n);
s2=sqrt(n);
t1=2*pi*rand(samples,1);
t2=2*pi*rand(samples,1);
s=cos(t2).*s2;
x=sin(t1).*s1;
y=cos(t1).*s1;
z=sin(t2).*s2;
q=[s,x,y,z];