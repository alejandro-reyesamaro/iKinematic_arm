% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 16/03/2010
% function: quaternionInnerProduct
% description:  quaternion inner product of two unit quaternions
%               definned in reference [21] at [Kuffner ICRA 2004]
%               input: quaternion q1 and q2
%               output: q = dot product of input
function [q]=quaternionInnerProduct(q1,q2)
s = q1(:,1).*q2(:,1);
x = q1(:,2).*q2(:,2);
y = q1(:,3).*q2(:,3);
z = q1(:,4).*q2(:,4);
q=[s,x,y,z];
