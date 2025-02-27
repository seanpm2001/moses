/**
 * Torizon IDE-backend API
 * Toradex API to build and deploy applications running as containers on Torizon
 *
 * The version of the OpenAPI document: 1.1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from './models';
import { DockerEndpointIPAMConfig } from './dockerEndpointIPAMConfig';

/**
* Configuration for a network endpoint.
*/
export class DockerEndpointSettings {
    'iPAMConfig'?: DockerEndpointIPAMConfig | null;
    'links'?: Array<string>;
    'aliases'?: Array<string>;
    /**
    * Unique ID of the network. 
    */
    'networkID'?: string;
    /**
    * Unique ID for the service endpoint in a Sandbox. 
    */
    'endpointID'?: string;
    /**
    * Gateway address for this network. 
    */
    'gateway'?: string;
    /**
    * IPv4 address. 
    */
    'iPAddress'?: string;
    /**
    * Mask length of the IPv4 address. 
    */
    'iPPrefixLen'?: number;
    /**
    * IPv6 gateway address. 
    */
    'iPv6Gateway'?: string;
    /**
    * Global IPv6 address. 
    */
    'globalIPv6Address'?: string;
    /**
    * Mask length of the global IPv6 address. 
    */
    'globalIPv6PrefixLen'?: number;
    /**
    * MAC address for the endpoint on this network. 
    */
    'macAddress'?: string;
    /**
    * DriverOpts is a mapping of driver options and values. These options are passed directly to the driver and are driver specific. 
    */
    'driverOpts'?: { [key: string]: string; } | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "iPAMConfig",
            "baseName": "IPAMConfig",
            "type": "DockerEndpointIPAMConfig"
        },
        {
            "name": "links",
            "baseName": "Links",
            "type": "Array<string>"
        },
        {
            "name": "aliases",
            "baseName": "Aliases",
            "type": "Array<string>"
        },
        {
            "name": "networkID",
            "baseName": "NetworkID",
            "type": "string"
        },
        {
            "name": "endpointID",
            "baseName": "EndpointID",
            "type": "string"
        },
        {
            "name": "gateway",
            "baseName": "Gateway",
            "type": "string"
        },
        {
            "name": "iPAddress",
            "baseName": "IPAddress",
            "type": "string"
        },
        {
            "name": "iPPrefixLen",
            "baseName": "IPPrefixLen",
            "type": "number"
        },
        {
            "name": "iPv6Gateway",
            "baseName": "IPv6Gateway",
            "type": "string"
        },
        {
            "name": "globalIPv6Address",
            "baseName": "GlobalIPv6Address",
            "type": "string"
        },
        {
            "name": "globalIPv6PrefixLen",
            "baseName": "GlobalIPv6PrefixLen",
            "type": "number"
        },
        {
            "name": "macAddress",
            "baseName": "MacAddress",
            "type": "string"
        },
        {
            "name": "driverOpts",
            "baseName": "DriverOpts",
            "type": "{ [key: string]: string; }"
        }    ];

    static getAttributeTypeMap() {
        return DockerEndpointSettings.attributeTypeMap;
    }
}

