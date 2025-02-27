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

/**
* Address represents an IPv4 or IPv6 IP address.
*/
export class DockerAddress {
    /**
    * IP address.
    */
    'addr'?: string;
    /**
    * Mask length of the IP address.
    */
    'prefixLen'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "addr",
            "baseName": "Addr",
            "type": "string"
        },
        {
            "name": "prefixLen",
            "baseName": "PrefixLen",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return DockerAddress.attributeTypeMap;
    }
}

