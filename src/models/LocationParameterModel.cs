using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2019 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Genevieve Conty
 * @author Greg Hester
 * Swagger name: AvaTaxClient
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// The parameter associated with a company location.
    /// </summary>
    public class LocationParameterModel
    {
        /// <summary>
        /// The ID number of the parameter.
        /// </summary>
        public Int64? id { get; set; }

        /// <summary>
        /// The parameter's name.
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// The parameter's value.
        /// </summary>
        public String unit { get; set; }

        /// <summary>
        /// The value of the parameter.
        /// </summary>
        public String value { get; set; }

        /// <summary>
        /// The ID of the company location the parameter associated with.
        /// </summary>
        public Int32? locationId { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
