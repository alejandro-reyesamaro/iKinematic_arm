%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 26/03/2010
% function: quaternionLogarithmicMap [Sebastian Grassia 1998]
% description:  Logarithmic map from S3 to R3
%               input: quaternion 
%               output: point
function[p] = quaternionLogarithmicMap(q)
p=[0,0,0];
if abs(q(1)<1.0)
    theta = acos(q(1));
    sin_theta = sin(theta);
    if abs(sin_theta>0.0001)
        sin_theta_over_theta = theta / sin_theta;
        p(1:3)=q(2:4)*sin_theta_over_theta;
    else
        p(1:3)=q(2:4);
    end
else
    p(1:3)=q(2:4);
end

