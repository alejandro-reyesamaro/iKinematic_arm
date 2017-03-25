% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 15/03/2010
% function: quaternionProduct
% description:  quaternion product
%               input: quaternion q1 and q2
%               output: q = dot product of input
function [q]=quaternionProduct(q1,q2)
x = q1(:,2) .* q2(:,1)  + q1(:,3) .* q2(:,4) - q1(:,4) .* q2(:,3) + q1(:,1) .* q2(:,2);
y = -q1(:,2) .* q2(:,4) + q1(:,3) .* q2(:,1) + q1(:,4) .* q2(:,2) + q1(:,1) .* q2(:,3);
z = q1(:,2) .* q2(:,3)  - q1(:,3) .* q2(:,2) + q1(:,4) .* q2(:,1) + q1(:,1) .* q2(:,4);
s = -q1(:,2) .* q2(:,2) - q1(:,3) .* q2(:,3) - q1(:,4) .* q2(:,4) + q1(:,1) .* q2(:,1);
q=[s,x,y,z];

% x = q1(2) * q2(1)  + q1(3) * q2(4) - q1(4) * q2(3) + q1(1) * q2(2);
% y = -q1(2) * q2(4) + q1(3) * q2(1) + q1(4) * q2(2) + q1(1) * q2(3);
% z = q1(2) * q2(3)  - q1(3) * q2(2) + q1(4) * q2(1) + q1(1) * q2(4);
% s = -q1(2) * q2(2) - q1(3) * q2(3) - q1(4) * q2(4) + q1(1) * q2(1);
% q=[s,x,y,z];