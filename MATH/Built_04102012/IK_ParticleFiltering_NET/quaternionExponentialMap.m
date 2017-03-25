%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 26/03/2010
% function: quaternionExponentialMap [Sebastian Grassia 1998]
% description:  Exponential map from R3 to S3
%               input: Point 3D 
%               output: quaternion
function[q] = quaternionExponentialMap(p)
theta = norm(p);
sin_theta = sin(theta);
q =[0 0 0 0];
q(1) = cos(theta);
if(abs(sin_theta)>0.00001)
    sin_theta_over_theta = sin_theta/theta;
    q(2:4) = p(1:3)*sin_theta_over_theta;
else
    q(2:4) = p(1:3);
end